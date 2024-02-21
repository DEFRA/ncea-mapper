using Moq;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Options;
using Ncea.Mapper.Infrastructure;
using Ncea.Mapper.Models;
using Ncea.Mapper.Constants;
using Microsoft.Extensions.Logging;
using Ncea.Mapper.Processors;

namespace Ncea.Mapper.Tests.Clients;

public static class ServiceBusServiceForTests
{
    public static ServiceBusService Get(out Mock<ServiceBusSender> mockServiceBusSender,
                                        out Mock<ServiceBusProcessor> mockServiceBusProcessor)
    {
        var appSettings = Options.Create(new MapperConfigurations() { Processor = new Processor() { ProcessorType = It.IsAny<ProcessorType>() } });
        var mockServiceBusClient = new Mock<ServiceBusClient>();
        mockServiceBusSender = new Mock<ServiceBusSender>();
        mockServiceBusProcessor = new Mock<ServiceBusProcessor>();
        var loggerMock = new Mock<ILogger<ServiceBusService>>();
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        // Set up the mock to return the mock sender
        mockServiceBusClient.Setup(x => x.CreateSender(It.IsAny<string>())).Returns(mockServiceBusSender.Object);
        mockServiceBusClient.Setup(x => x.CreateProcessor(It.IsAny<string>(), It.IsAny<ServiceBusProcessorOptions>())).Returns(mockServiceBusProcessor.Object);
        return service;
    }

    public static ServiceBusService GetServiceBusWithError(out Mock<ServiceBusSender> mockServiceBusSender,
                                                           out Mock<ServiceBusProcessor> mockServiceBusProcessor)
    {
        var appSettings = Options.Create(new MapperConfigurations() { Processor = new Processor() { ProcessorType = It.IsAny<ProcessorType>() } });
        var mockServiceBusClient = new Mock<ServiceBusClient>();
        mockServiceBusSender = new Mock<ServiceBusSender>();
        mockServiceBusProcessor = new Mock<ServiceBusProcessor>();
        var loggerMock = new Mock<ILogger<ServiceBusService>>();
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        mockServiceBusSender.Setup(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), It.IsAny<CancellationToken>())).Throws<Exception>();
        // Set up the mock to return the mock sender
        mockServiceBusClient.Setup(x => x.CreateSender(It.IsAny<string>())).Returns(mockServiceBusSender.Object);
        mockServiceBusClient.Setup(x => x.CreateProcessor(It.IsAny<string>(), It.IsAny<ServiceBusProcessorOptions>())).Returns(mockServiceBusProcessor.Object);

        return service;
    }
}
