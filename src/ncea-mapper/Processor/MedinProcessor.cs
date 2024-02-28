using Ncea.Mapper.Processors.Contracts;

namespace Ncea.Mapper.Processors;

public class MedinProcessor : IProcessor
{    
    private readonly ILogger<MedinProcessor> _logger;

    public MedinProcessor(ILogger<MedinProcessor> logger)
    {     
        _logger = logger;
    }
    public Task Process(CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
