﻿using Moq;
using Azure.Messaging.ServiceBus;
using Ncea.Mapper.Models;
using Ncea.Mapper.Constants;
using Microsoft.Extensions.Logging;
using ncea.mapper.Processor.Contracts;

namespace Ncea.Mapper.Tests.Clients;

public static class ServiceBusServiceForTests
{
    public static void Get<T>(out MapperConfiguration appSettings,
                            out Mock<ServiceBusClient> mockServiceBusClient,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<T>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor)
    {
        appSettings = new MapperConfiguration() {  ProcessorType = It.IsAny<ProcessorType>() };
        mockServiceBusClient = new Mock<ServiceBusClient>();
        mockServiceBusSender = new Mock<ServiceBusSender>();
        mockServiceBusProcessor = new Mock<ServiceBusProcessor>();
        loggerMock = new Mock<ILogger<T>>(MockBehavior.Strict);
        loggerMock.Setup(x => x.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()
            )
        );
        loggerMock.Setup(x => x.Log(
                LogLevel.Error,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()
            )
        );
        mockOrchestrationService = new Mock<IOrchestrationService>();

        // Set up the mock to return the mock sender
        mockServiceBusProcessor.Setup(x => x.StartProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        mockServiceBusClient.Setup(x => x.CreateSender(It.IsAny<string>())).Returns(mockServiceBusSender.Object);
        mockServiceBusClient.Setup(x => x.CreateProcessor(It.IsAny<string>(), It.IsAny<ServiceBusProcessorOptions>())).Returns(mockServiceBusProcessor.Object);
        mockOrchestrationService.Setup(x => x.StartProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
    }
}
