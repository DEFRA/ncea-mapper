using System.Text;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using ncea.mapper.Processor.Contracts;
using Ncea.Mapper.Processors.Contracts;

namespace ncea.mapper.Processor;

public class OrchestrationService : IOrchestrationService
{
    private readonly ServiceBusSender _sender;
    private readonly ServiceBusProcessor _processor;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<OrchestrationService> _logger;

    public OrchestrationService(IConfiguration configuration,
        IAzureClientFactory<ServiceBusSender> serviceBusSenderFactory,
        IAzureClientFactory<ServiceBusProcessor> serviceBusProcessorFactory,
        IServiceProvider serviceProvider,
        ILogger<OrchestrationService> logger)
    {
        var harvesterQueueName = configuration.GetValue<string>("HarvesterQueueName");
        var mapperQueueName = configuration.GetValue<string>("MapperQueueName");

        _processor = serviceBusProcessorFactory.CreateClient(harvesterQueueName);
        _sender = serviceBusSenderFactory.CreateClient(mapperQueueName);
        _serviceProvider = serviceProvider;
        _logger = logger;
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

    public async Task SendMessageAsync(string message, CancellationToken cancellationToken = default)
    {
        var messageInBytes = Encoding.UTF8.GetBytes(message);
        var serviceBusMessage = new ServiceBusMessage(messageInBytes);
        await _sender.SendMessageAsync(serviceBusMessage, cancellationToken);
    }

    private async Task ProcessMessagesAsync(ProcessMessageEventArgs args)
    {
        try
        {
            var body = args.Message.Body.ToString();
            var dataSource = args.Message.ApplicationProperties["DataSource"].ToString();
            var mdcMappedData = await _serviceProvider.GetRequiredKeyedService<IMapperService>(dataSource).Transform(body);
            await SendMessageAsync(mdcMappedData);

            await args.CompleteMessageAsync(args.Message);
        }
        catch (Exception ex)
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
}
