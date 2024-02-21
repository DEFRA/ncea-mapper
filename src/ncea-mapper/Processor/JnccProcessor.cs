using HtmlAgilityPack;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Infrastructure.Models.Requests;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using System.Text;

namespace Ncea.Mapper.Processors;

public class JnccProcessor : IProcessor
{
    private readonly IServiceBusService _serviceBusService;
    private readonly ILogger<JnccProcessor> _logger;
    private readonly MapperConfigurations _mapperConfigurations;

    public JnccProcessor(IServiceBusService serviceBusService, 
                        ILogger<JnccProcessor> logger,
                        MapperConfigurations mapperConfigurations)
    {
        _mapperConfigurations = mapperConfigurations;
        _serviceBusService = serviceBusService;
        _logger = logger;
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
        await _serviceBusService.SendMessageAsync(message);
    }
}
