namespace ncea.mapper.Processor.Contracts;

public interface IOrchestrationService
{
    Task StartProcessorAsync(CancellationToken cancellationToken = default);
}
