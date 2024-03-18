using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using ncea.mapper.Processor.Contracts;
using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper;

[ExcludeFromCodeCoverage]
public class Worker : BackgroundService
{
    private readonly ILogger _logger;
    private readonly TelemetryClient _telemetryClient;
    private readonly IOrchestrationService _orchetrator;

    public Worker(IOrchestrationService orchetrator, TelemetryClient telemetryClient, ILogger<Worker> logger)
    {
        _orchetrator = orchetrator;
        _telemetryClient = telemetryClient;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Ncea Mapping service started at: {time}", DateTimeOffset.Now);

        using (_telemetryClient.StartOperation<RequestTelemetry>("operation"))
        {
            await _orchetrator.StartProcessorAsync(stoppingToken);

            _telemetryClient.TrackEvent("Ncea Mapping service up and running...");

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);

                _telemetryClient.TrackEvent("Ncea Mapping service up and running...");
            }
        }

        _logger.LogInformation("Ncea Mapping service stopped at: {time}", DateTimeOffset.Now);
    }
}
