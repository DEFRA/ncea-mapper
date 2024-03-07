namespace Ncea.Mapper.Processors.Contracts;

public interface IMapperService
{
    Task<string> Transform(string harvestedData, CancellationToken cancellationToken = default);
}