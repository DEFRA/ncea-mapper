namespace Ncea.Mapper.Infrastructure.Contracts;

public interface IServiceBusService
{
    void CreateProcessor(Func<string, Task> messageHandler);
    Task StartProcessingAsync(CancellationToken cancellationToken = default);
    Task StopProcessingAsync(CancellationToken cancellationToken = default);
    Task SendMessageAsync(string message);
}
