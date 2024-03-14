using Ncea.Mapper.Processors.Contracts;

namespace Ncea.Mapper.Processors;

public class JnccMapper : IMapperService
{
    private readonly ILogger<JnccMapper> _logger;

    public JnccMapper(ILogger<JnccMapper> logger)
    {
        _logger = logger;
    }
    public async Task<string> Transform(string harvestedData, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Jncc transformer");
        return await Task.FromResult(harvestedData);
    }
}
