using Cronos;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.Extensions.Options;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper;

[ExcludeFromCodeCoverage]
public class Worker : BackgroundService
{
    private readonly ILogger _logger;
    private readonly TelemetryClient _telemetryClient;
    private readonly MapperConfigurations _mapperConfigurations;
    private readonly IProcessor _processor;

    public Worker(ILogger<Worker> logger, MapperConfigurations mapperConfigurations, IProcessor processor, TelemetryClient telemetryClient)
    {
        _logger = logger;
        _mapperConfigurations = mapperConfigurations;
        _processor = processor;
        _telemetryClient = telemetryClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

            using (_telemetryClient.StartOperation<RequestTelemetry>("operation"))
            {
                _logger.LogInformation("Metadata harversting started for {source}", _mapperConfigurations.ProcessorType);
                await _processor.Process(stoppingToken);
                _logger.LogInformation("Metadata harversting completed");
                _telemetryClient.TrackEvent("Harvesting completed");
            }
        }
    }
}
