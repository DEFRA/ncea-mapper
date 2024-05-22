namespace Ncea.Mapper.Processor.Contracts;

public interface IOrchestrationService
{
    Task StartProcessorAsync(CancellationToken cancellationToken = default);
}
