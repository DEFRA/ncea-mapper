using Ncea.Mapper.Processors.Contracts;

namespace Ncea.Mapper.Processors;

public class JnccProcessor : IProcessor
{
    private readonly ILogger<JnccProcessor> _logger;

    public JnccProcessor(ILogger<JnccProcessor> logger)
    {
        _logger = logger;
    }
    public Task Process(CancellationToken cancellationToken = default)
    {
        return Task.CompletedTask;
    }
}
