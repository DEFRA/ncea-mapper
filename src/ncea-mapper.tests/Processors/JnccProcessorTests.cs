using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;

namespace Ncea.Mapper.Tests.Processors;

public class JnccProcessorTests
{
    [Fact]
    public async Task Process_ShouldSendMessagesToServiceBus() {
        //Arrange
        ServiceBusServiceForTests.Get<JnccProcessor>(out MapperConfiguration appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<JnccProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var logger = new Logger<JnccProcessor>(new LoggerFactory());
        // Act
        var jnccService = new JnccProcessor(mockServiceBusService.Object, logger);
        await jnccService.Process();

        // Assert
        mockServiceBusService.Verify(x => x.CreateProcessor(It.IsAny<Func<string, Task>>()), Times.Once);
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Process_ShouldNotSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<JnccProcessor>(out MapperConfiguration appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<JnccProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        // Act
        var jnccService = new JnccProcessor(mockServiceBusService.Object, loggerMock.Object);
        await jnccService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task HandleMessage_ShouldSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<JnccProcessor>(out MapperConfiguration appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<JnccProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var jnccService = new JnccProcessor(mockServiceBusService.Object, loggerMock.Object);
        var handleMessageMethod = typeof(JnccProcessor).GetMethod("HandleMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var task = (Task?)handleMessageMethod?.Invoke(jnccService, new object[] { "test-param" });


        // Act
        if(task != null) await task;


        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Information,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
        mockServiceBusService.Verify(x => x.SendMessageAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
