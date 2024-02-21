using Azure.Messaging.ServiceBus;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using Ncea.Mapper.Constants;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;
using System.Net;

namespace Ncea.Mapper.Tests.Processors;

public class JnccProcessorTests
{
    [Fact]
    public async Task Process_ShouldSendMessagesToServiceBus() {
        //Arrange
        var serviceBusService = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender> mockServiceBusSender,
                                                              out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var appSettings = new MapperConfigurations() {  DataSourceApiBase="https://base-uri", DataSourceApiUrl="/test-url", ProcessorType= ProcessorType.Jncc, Type="" };
        var logger = new Logger<JnccProcessor>(new LoggerFactory());
        // Act
        var jnccService = new JnccProcessor(serviceBusService, logger, appSettings);
        await jnccService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Process_ShouldNotSendMessagesToServiceBus()
    {
        //Arrange
        var serviceBusService = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender> mockServiceBusSender,
                                                              out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var appSettings = new MapperConfigurations() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Jncc, Type = "" };
        var loggerMock = new Mock<ILogger<JnccProcessor>>();

        // Act
        var jnccService = new JnccProcessor(serviceBusService, loggerMock.Object, appSettings);
        await jnccService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }
}
