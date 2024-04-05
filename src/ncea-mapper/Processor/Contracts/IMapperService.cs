namespace Ncea.Mapper.Processors.Contracts;

public interface IMapperService
{
    Task<string> Transform(string mdcSchemaLocation, string harvestedData, CancellationToken cancellationToken = default);
}