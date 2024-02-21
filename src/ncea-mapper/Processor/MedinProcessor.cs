using Microsoft.Extensions.Options;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Infrastructure.Models.Requests;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using System.Text;
using System.Xml.Linq;

namespace Ncea.Mapper.Processors;

public class MedinProcessor : IProcessor
{
    private readonly IApiClient _apiClient;
    private readonly IServiceBusService _serviceBusService;
    private readonly IBlobService _blobService;
    private readonly ILogger<MedinProcessor> _logger;
    private readonly MapperConfigurations _mapperConfigurations;

    public MedinProcessor(IApiClient apiClient,
        IServiceBusService serviceBusService,
        IBlobService blobService,
        ILogger<MedinProcessor> logger,
        IOptions<MapperConfigurations> mapperConfigurations)
    {
        _apiClient = apiClient;
        _mapperConfigurations = mapperConfigurations.Value;
        _apiClient.CreateClient(_mapperConfigurations.Processor.DataSourceApiBase);
        _serviceBusService = serviceBusService;
        _logger = logger;
        _blobService = blobService;
    }
    public Task Process(CancellationToken cancellationToken = default)
    {
        _serviceBusService.CreateProcessor(HandleMessage);
        _serviceBusService.StartProcessingAsync(cancellationToken);
        return Task.CompletedTask;
    }

    private async Task HandleMessage(string message)
    {
        var processedMessage = message;
        _logger.LogInformation(processedMessage);
        _logger.LogInformation(nameof(_blobService));
        await _serviceBusService.SendMessageAsync(message);
    }
}
