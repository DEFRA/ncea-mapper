using System.Text;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Options;
using Ncea.Mapper.Models;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Processors.Contracts;
using Ncea.Mapper.Processors;

namespace Ncea.Mapper.Infrastructure;

public class ServiceBusService : IServiceBusService
{
    private readonly ServiceBusClient _queueClient;
    private readonly string _serviceBusHarvesterQueueName;
    private readonly string _serviceBusMapperQueueName;
    private readonly ILogger<ServiceBusService> _logger;
    private Func<string, Task>? _messageHandler;
    private ServiceBusProcessor _processor = null!;
    public ServiceBusService(MapperConfigurations mapperConfigurations, 
                             ServiceBusClient queueClient,
                             ILogger<ServiceBusService> logger)
    {
        _queueClient = queueClient;
        _serviceBusHarvesterQueueName = $"{mapperConfigurations.ProcessorType}-harvester-queue";
        _serviceBusMapperQueueName = $"{mapperConfigurations.ProcessorType}-mapper-queue";
        _logger = logger;
    }

    public ServiceBusProcessor CreateProcessor(Func<string, Task>? messageHandler)
    {
        _processor = _queueClient.CreateProcessor(_serviceBusHarvesterQueueName, new ServiceBusProcessorOptions() { AutoCompleteMessages = false });
        _messageHandler = messageHandler;
        return _processor;
    }

    public async Task StartProcessingAsync(CancellationToken cancellationToken = default)
    {
        _processor.ProcessMessageAsync += ProcessMessagesAsync;
        _processor.ProcessErrorAsync += ErrorHandlerAsync;
        await _processor.StartProcessingAsync(cancellationToken);
    }

    public async Task StopProcessingAsync(CancellationToken cancellationToken = default)
    {
        await _processor.StopProcessingAsync(cancellationToken);
    }

    private async Task ProcessMessagesAsync(ProcessMessageEventArgs args)
    {
        try
        {
            string body = args.Message.Body.ToString();
            await _messageHandler!(body);
            await args.CompleteMessageAsync(args.Message);
        } 
        catch(Exception ex)
        {
            _logger.LogError("Error processing message: {ex.Message}", ex.Message);
            await args.AbandonMessageAsync(args.Message);
        }
    }

    private Task ErrorHandlerAsync(ProcessErrorEventArgs args)
    {
        _logger.LogError("Error processing message: {args.Exception.Message}", args.Exception.Message);
        return Task.CompletedTask;
    }

    public async Task SendMessageAsync(string message, CancellationToken cancellationToken = default)
    {
        var sender = _queueClient.CreateSender(_serviceBusMapperQueueName);
        var messageInBytes = Encoding.UTF8.GetBytes(message);
        var serviceBusMessage = new ServiceBusMessage(messageInBytes);
        await sender.SendMessageAsync(serviceBusMessage, cancellationToken);
    }
}
