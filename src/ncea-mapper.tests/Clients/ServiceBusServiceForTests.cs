using Moq;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Options;
using Ncea.Mapper.Infrastructure;
using Ncea.Mapper.Models;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Constants;
using Microsoft.Extensions.Logging;
using Ncea.Mapper.Processors;

namespace Ncea.Mapper.Tests.Clients;

public static class ServiceBusServiceForTests
{
    public static void Get<T>(out MapperConfigurations appSettings,
                            out Mock<ServiceBusClient> mockServiceBusClient,
                            out Mock<IServiceBusService> mockServiceBusService,
                            out Mock<ILogger<T>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor)
    {
        appSettings = new MapperConfigurations() {  ProcessorType = It.IsAny<ProcessorType>() };
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
        mockServiceBusService = new Mock<IServiceBusService>();

        // Set up the mock to return the mock sender
        mockServiceBusProcessor.Setup(x => x.StartProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        mockServiceBusClient.Setup(x => x.CreateSender(It.IsAny<string>())).Returns(mockServiceBusSender.Object);
        mockServiceBusClient.Setup(x => x.CreateProcessor(It.IsAny<string>(), It.IsAny<ServiceBusProcessorOptions>())).Returns(mockServiceBusProcessor.Object);
        mockServiceBusService.Setup(x => x.CreateProcessor(It.IsAny<Func<string, Task>>())).Returns(mockServiceBusProcessor.Object);
    }

    //public static ServiceBusService GetServiceBusWithError(out Mock<ServiceBusSender> mockServiceBusSender,
    //                                                       out Mock<ServiceBusProcessor> mockServiceBusProcessor)
    //{
    //    var appSettings = new MapperConfigurations() { ProcessorType = It.IsAny<ProcessorType>() };
    //    var mockServiceBusClient = new Mock<ServiceBusClient>();
    //    mockServiceBusSender = new Mock<ServiceBusSender>();
    //    mockServiceBusProcessor = new Mock<ServiceBusProcessor>();
    //    loggerMock = new Mock<ILogger<T>>(MockBehavior.Strict);
    //    loggerMock.Setup(x => x.Log(
    //            LogLevel.Information,
    //            It.IsAny<EventId>(),
    //            It.IsAny<It.IsAnyType>(),
    //            It.IsAny<Exception>(),
    //            It.IsAny<Func<It.IsAnyType, Exception?, string>>()
    //        )
    //    );
    //    loggerMock.Setup(x => x.Log(
    //            LogLevel.Error,
    //            It.IsAny<EventId>(),
    //            It.IsAny<It.IsAnyType>(),
    //            It.IsAny<Exception>(),
    //            It.IsAny<Func<It.IsAnyType, Exception?, string>>()
    //        )
    //    );

    //    mockServiceBusClient.Setup(x => x.CreateSender(It.IsAny<string>())).Returns(mockServiceBusSender.Object);
    //    mockServiceBusClient.Setup(x => x.CreateProcessor(It.IsAny<string>(), It.IsAny<ServiceBusProcessorOptions>())).Returns(mockServiceBusProcessor.Object);
    //    var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
    //    mockServiceBusSender.Setup(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), It.IsAny<CancellationToken>())).Throws<Exception>();
    //    mockServiceBusProcessor.Setup(x => x.StartProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
    //    mockServiceBusProcessor.Setup(x => x.StopProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        
    //    return service;
    //}
}
