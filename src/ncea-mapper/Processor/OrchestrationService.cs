﻿using System.Text;
using System.Text.Json;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Ncea.Mapper.Processor.Contracts;
using Ncea.mapper.Infrastructure.Contracts;
using Ncea.Mapper.Infrastructure.Models.Requests;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using System.Text.Json.Serialization;

namespace Ncea.Mapper.Processor;

public class OrchestrationService : IOrchestrationService
{
    private const string ProcessorErrorMessage = "Error in processing message in ncea-mapper service";

    private readonly ServiceBusSender _sender;
    private readonly IBlobService _blobService;
    private readonly ServiceBusProcessor _processor;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<OrchestrationService> _logger;
    private readonly string? _mdcSchemaLocation;

    public OrchestrationService(IConfiguration configuration,
        IBlobService blobService,
        IAzureClientFactory<ServiceBusSender> serviceBusSenderFactory,
        IAzureClientFactory<ServiceBusProcessor> serviceBusProcessorFactory,
        IServiceProvider serviceProvider,
        ILogger<OrchestrationService> logger)
    {
        var harvesterQueueName = configuration.GetValue<string>("HarvesterQueueName");
        var mapperQueueName = configuration.GetValue<string>("MapperQueueName");
        _mdcSchemaLocation = configuration.GetValue<string>("MdcSchemaLocation");

        _processor = serviceBusProcessorFactory.CreateClient(harvesterQueueName);
        _sender = serviceBusSenderFactory.CreateClient(mapperQueueName);
        _blobService = blobService;
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public async Task StartProcessorAsync(CancellationToken cancellationToken = default)
    {
        _processor.ProcessMessageAsync += ProcessMessagesAsync;
        _processor.ProcessErrorAsync += ErrorHandlerAsync;
        await _processor.StartProcessingAsync(cancellationToken);
    }

    private async Task SendMessageAsync(string message, CancellationToken cancellationToken = default)
    {
        var messageInBytes = Encoding.UTF8.GetBytes(message);
        var serviceBusMessage = new ServiceBusMessage(messageInBytes);
        await _sender.SendMessageAsync(serviceBusMessage, cancellationToken);
    }

    private async Task ProcessMessagesAsync(ProcessMessageEventArgs args)
    {
        var options = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };

        try
        {
            var body = Encoding.UTF8.GetString(args.Message.Body);            
            var harvestedRecord =  JsonSerializer.Deserialize<HarvestedRecordMessage>(body, options)!;
            var dataSource = harvestedRecord.DataSource.ToString().ToLowerInvariant();

            var request = new GetBlobContentRequest(harvestedRecord.FileIdentifier, dataSource);
            var harvestedContent = await _blobService.GetContentAsync(request, args.CancellationToken);

            var mdcMappedData = await _serviceProvider
                .GetRequiredKeyedService<IMapperService>(harvestedRecord!.DataSource.ToString())
                .Transform(_mdcSchemaLocation!, harvestedContent);

            var xmlStream = new MemoryStream(Encoding.UTF8.GetBytes(mdcMappedData));
            var xmlFileName = string.Concat(harvestedRecord.FileIdentifier, ".xml");

            await _blobService.SaveAsync(new SaveBlobRequest(xmlStream, xmlFileName, dataSource), args.CancellationToken);

            var mdcMappedRecord = new MdcMappedRecordMessage(harvestedRecord.FileIdentifier, harvestedRecord.DataSource);
            var messageToEnricher = JsonSerializer.Serialize(mdcMappedRecord, options);

            await SendMessageAsync(messageToEnricher);

            await args.CompleteMessageAsync(args.Message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ProcessorErrorMessage);
            await args.AbandonMessageAsync(args.Message);
        }
    }

    private Task ErrorHandlerAsync(ProcessErrorEventArgs args)
    {
        _logger.LogError(args.Exception, ProcessorErrorMessage);
        return Task.CompletedTask;
    }
}
