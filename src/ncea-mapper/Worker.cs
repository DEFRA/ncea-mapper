using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Ncea.Mapper.Processor.Contracts;
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
        await _orchetrator.StartProcessorAsync(stoppingToken);

        _logger.LogInformation("Ncea Mapping service started at: {time}", DateTimeOffset.Now);

        while (!stoppingToken.IsCancellationRequested)
        {
            using (_telemetryClient.StartOperation<RequestTelemetry>("operation"))
            {
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);

                _telemetryClient.TrackEvent("Ncea Mapper service up and running...");
            }
        }

        _logger.LogInformation("Ncea Mapping service stopped at: {time}", DateTimeOffset.Now);
    }
}
