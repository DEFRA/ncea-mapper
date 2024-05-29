using System.Text;
using System.Text.Json;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Ncea.Mapper.Processor.Contracts;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Infrastructure.Models.Requests;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using System.Text.Json.Serialization;
using Ncea.Mapper.Enums;
using Azure;
using Ncea.Mapper.Utils;
using Ncea.Mapper.BusinessExceptions;
using System.Xml.Schema;

namespace Ncea.Mapper.Processor;

public class OrchestrationService : IOrchestrationService
{
    private const string ProcessorErrorMessage = "Error in processing message in ncea-mapper service";

    private readonly ServiceBusSender _sender;
    private readonly IBlobService _blobService;
    private readonly ServiceBusProcessor _processor;
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<OrchestrationService> _logger;
    private static readonly JsonSerializerOptions _serializerOptions = new()
    {
        Converters = { new JsonStringEnumConverter() }
    };
    private readonly string _mdcSchemaLocation;
    private readonly string _mapperStagingContainerSuffix;

    public OrchestrationService(IConfiguration configuration,
        IBlobService blobService,
        IAzureClientFactory<ServiceBusSender> serviceBusSenderFactory,
        IAzureClientFactory<ServiceBusProcessor> serviceBusProcessorFactory,
        IServiceProvider serviceProvider,
        ILogger<OrchestrationService> logger)
    {
        var harvesterQueueName = configuration.GetValue<string>("HarvesterQueueName");
        var mapperQueueName = configuration.GetValue<string>("MapperQueueName");
        _mdcSchemaLocation = configuration.GetValue<string>("MdcSchemaLocation")!;
        _mapperStagingContainerSuffix = configuration.GetValue<string>("MapperStagingContainerSuffix")!;

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

    private async Task ProcessMessagesAsync(ProcessMessageEventArgs args)
    {
        var dataSource = string.Empty;
        var fileIdentifier = string.Empty;
        try
        {
            if (string.IsNullOrWhiteSpace(args.Message.Body.ToString()))
            {
                throw new ArgumentException("Harvested-queue message body should not be empty");
            }

            var body = Encoding.UTF8.GetString(args.Message.Body);            
            var harvestedRecord =  JsonSerializer.Deserialize<HarvestedRecordMessage>(body, _serializerOptions)!;

            dataSource = harvestedRecord.DataSource.ToString();
            fileIdentifier = harvestedRecord.FileIdentifier;

            _logger.LogInformation("Mapper summary | Mapping started for DataSource : {dataSource}, FileIdentifier : {fileIdentifier}", dataSource, fileIdentifier);

            var dataSourceNameInLowerCase = dataSource.ToLowerInvariant();
            var fileExtension = (harvestedRecord.DataFormat == DataFormat.Csv) ? ".csv" : ".xml";
            var fileName = string.Concat(harvestedRecord.FileIdentifier, fileExtension);
            var mapperStagingContainer = $"{dataSourceNameInLowerCase}-{_mapperStagingContainerSuffix}";

            var request = new GetBlobContentRequest(fileName, dataSourceNameInLowerCase);
            var harvestedContent = await _blobService.GetContentAsync(request, args.CancellationToken);

            var mdcMappedData = await _serviceProvider
                .GetRequiredKeyedService<IMapperService>(dataSource)
                .Transform(_mdcSchemaLocation!, harvestedContent);

            var xmlStream = new MemoryStream(Encoding.UTF8.GetBytes(mdcMappedData));            
            await _blobService.SaveAsync(new SaveBlobRequest(xmlStream, fileName, mapperStagingContainer), args.CancellationToken);

            var mdcMappedRecord = new MdcMappedRecordMessage(harvestedRecord.FileIdentifier, harvestedRecord.DataSource);
            var messageToEnricher = JsonSerializer.Serialize(mdcMappedRecord, _serializerOptions);

            await SendMessageAsync(messageToEnricher);

            _logger.LogInformation("Mapper summary | Mapping completed for DataSource : {dataSource}, FileIdentifier : {fileIdentifier}", dataSource, fileIdentifier);

            await args.CompleteMessageAsync(args.Message);
        }
        catch (ArgumentException ex)
        {
            await HandleException(args, ex, new MapperArgumentException(ex.Message, ex));
        }
        catch (RequestFailedException ex)
        {
            var errorMessage = $"Error occured while reading the harvested file during mdc mapping process for Data source: {dataSource}, file-id: {fileIdentifier}";
            await HandleException(args, ex, new BlobStorageNotAccessibleException(errorMessage, ex));
        }
        catch (XmlSchemaValidationException ex)
        {
            await HandleException(args, ex, new XmlValidationException(ex.Message, ex));
        }
        catch (Exception ex)
        {
            var errorMessage = $"Error occured during mdc mapping process for Data source: {dataSource}, file-id: {fileIdentifier}";
            await HandleException(args, ex, new MapperException(errorMessage, ex));
        }
    }

    private async Task SendMessageAsync(string message, CancellationToken cancellationToken = default)
    {
        var messageInBytes = Encoding.UTF8.GetBytes(message);
        var serviceBusMessage = new ServiceBusMessage(messageInBytes);
        await _sender.SendMessageAsync(serviceBusMessage, cancellationToken);
    }

    private Task ErrorHandlerAsync(ProcessErrorEventArgs args)
    {
        _logger.LogError(args.Exception, ProcessorErrorMessage);
        return Task.CompletedTask;
    }
    private async Task HandleException(ProcessMessageEventArgs args, Exception ex, BusinessException businessException)
    {
        CustomLogger.LogErrorMessage(_logger, businessException.Message, ex);
        await args.AbandonMessageAsync(args.Message);
        throw businessException;
    }
}