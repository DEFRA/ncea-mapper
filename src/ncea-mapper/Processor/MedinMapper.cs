using Ncea.Mapper.Processors.Contracts;

namespace Ncea.Mapper.Processors;

public class MedinMapper : IMapperService
{    
    private readonly ILogger<MedinMapper> _logger;

    public MedinMapper(ILogger<MedinMapper> logger)
    {     
        _logger = logger;
    }
    public async Task<string> Transform(string harvestedData, CancellationToken cancellationToken = default)
    {
        return await Task.FromResult(harvestedData);
    }
}
