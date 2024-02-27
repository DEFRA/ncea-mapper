﻿using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Processors.Contracts;

namespace Ncea.Mapper.Processors;

public class MedinProcessor : IProcessor
{
    private readonly IServiceBusService _serviceBusService;
    private readonly ILogger<MedinProcessor> _logger;

    public MedinProcessor(IServiceBusService serviceBusService,
                        ILogger<MedinProcessor> logger)
    {
        _serviceBusService = serviceBusService;
        _logger = logger;
    }
    public Task Process(CancellationToken cancellationToken = default)
    {
        
        var processor = _serviceBusService.CreateProcessor(HandleMessage);
        processor.StartProcessingAsync(cancellationToken);
        return Task.CompletedTask;
    }

    private async Task HandleMessage(string message)
    {
        var processedMessage = message;
        _logger.LogInformation("Processed Metadata xml:\n{processedMessage}", processedMessage);
        await _serviceBusService.SendMessageAsync(message);
    }
}
