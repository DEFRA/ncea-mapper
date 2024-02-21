namespace Ncea.Mapper.Processors.Contracts;

public interface IProcessor
{
    Task Process(CancellationToken cancellationToken = default);
}