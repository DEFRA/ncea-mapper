namespace ncea.mapper.Processor.Contracts;

public interface IOrchestrationService
{
    Task StartProcessingAsync(CancellationToken cancellationToken = default);
    Task StopProcessingAsync(CancellationToken cancellationToken = default);
    Task SendMessageAsync(string message, CancellationToken cancellationToken = default);
}
