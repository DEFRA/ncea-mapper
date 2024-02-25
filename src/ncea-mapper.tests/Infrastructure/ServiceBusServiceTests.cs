using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Mapper.Infrastructure;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Models;
using Ncea.Mapper.Tests.Clients;
using System.Reflection;

namespace Ncea.Mapper.Tests.Infrastructure;

public class ServiceBusServiceTests
{
    [Fact]
    public async Task SendMessage_ShouldSendMessageToQueue()
    {
        // Arrange
        ServiceBusServiceForTests.Get(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<ServiceBusService>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        
        // Act
        await service.SendMessageAsync("Test Message", It.IsAny<CancellationToken>());

        // Assert
        mockServiceBusClient.Verify(x => x.CreateSender(It.IsAny<string>()), Times.Once);
        mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task CreateProcessor_ShouldCall_CreateProcessor_On_ServiceBusClient()
    {
        // Arrange
        ServiceBusServiceForTests.Get(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<ServiceBusService>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        // Act
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        service.CreateProcessor(It.IsAny<Func<string, Task>>());
        await service.StartProcessingAsync(It.IsAny<CancellationToken>());
        await service.StopProcessingAsync(It.IsAny<CancellationToken>());

        // Assert
        mockServiceBusClient.Verify(x => x.CreateProcessor(It.IsAny<string>(), It.IsAny<ServiceBusProcessorOptions>()), Times.Once);
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
        mockServiceBusProcessor.Verify(x => x.StopProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task ErrorHandlerAsync_Should_Complete_Task()
    {
        // Arrange
        ServiceBusServiceForTests.Get(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<ServiceBusService>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        var args = new ProcessErrorEventArgs(new Exception("test-exception"), It.IsAny<ServiceBusErrorSource>(),
                                             It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                                             It.IsAny<CancellationToken>());
        var errorHandlerMethod = typeof(ServiceBusService).GetMethod("ErrorHandlerAsync", BindingFlags.NonPublic | BindingFlags.Instance);
        var task = (Task?)errorHandlerMethod?.Invoke(service, new object[] { args });


        // Act        
        if (task != null) await task;


        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Error, 
            It.IsAny<EventId>(), 
            It.IsAny<It.IsAnyType>(), 
            It.IsAny<Exception>(), 
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
        Assert.True(task?.IsCompleted);
    }

    [Fact]
    public async Task ProcessMessagesAsync_Should_CompleteMessageAsync()
    {
        // Arrange
        ServiceBusServiceForTests.Get(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<ServiceBusService>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        
        var receivedMessage = ServiceBusModelFactory.ServiceBusReceivedMessage(body: new BinaryData("message"), messageId: "messageId");
        var mockReceiver = new Mock<ServiceBusReceiver>();
        mockServiceBusClient.Setup(x => x.CreateReceiver(It.IsAny<string>())).Returns(mockReceiver.Object);
        var processMessageEventArgs = new ProcessMessageEventArgs(receivedMessage, It.IsAny<ServiceBusReceiver>(), It.IsAny<CancellationToken>());
        var mockProcessMessageEventArgs = new Mock<ProcessMessageEventArgs>(MockBehavior.Strict, new object[] { receivedMessage, mockReceiver.Object, It.IsAny<string>(), It.IsAny<CancellationToken>() });
        mockProcessMessageEventArgs.Setup(receiver => receiver.CompleteMessageAsync(It.IsAny<ServiceBusReceivedMessage>(),It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);

        // Act
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        service.CreateProcessor((string message) => { return Task.CompletedTask; });

        var processMessagesAsyncMethod = typeof(ServiceBusService).GetMethod("ProcessMessagesAsync", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var task = (Task)(processMessagesAsyncMethod?.Invoke(service, new object[] { mockProcessMessageEventArgs.Object }));
        await task;

        // Assert
        mockProcessMessageEventArgs.Verify(x => x.CompleteMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task ProcessMessagesAsync_WithError_Should_AbandonMessageAsync()
    {
        // Arrange
        ServiceBusServiceForTests.Get(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<ServiceBusService>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        var receivedMessage = ServiceBusModelFactory.ServiceBusReceivedMessage(body: null, messageId: "messageId");
        var mockReceiver = new Mock<ServiceBusReceiver>();
        mockServiceBusClient.Setup(x => x.CreateReceiver(It.IsAny<string>())).Returns(mockReceiver.Object);
        var processMessageEventArgs = new ProcessMessageEventArgs(receivedMessage, It.IsAny<ServiceBusReceiver>(), It.IsAny<CancellationToken>());
        var mockProcessMessageEventArgs = new Mock<ProcessMessageEventArgs>(MockBehavior.Strict, new object[] { receivedMessage, mockReceiver.Object, It.IsAny<string>(), It.IsAny<CancellationToken>() });
        mockProcessMessageEventArgs.Setup(x => x.AbandonMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<IDictionary<string, object>>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);

        // Act
        var service = new ServiceBusService(appSettings, mockServiceBusClient.Object, loggerMock.Object);
        service.CreateProcessor((string message) => { return Task.CompletedTask; });

        var processMessagesAsyncMethod = typeof(ServiceBusService).GetMethod("ProcessMessagesAsync", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var task = (Task)(processMessagesAsyncMethod?.Invoke(service, new object[] { mockProcessMessageEventArgs.Object }));
        await task;

        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Error,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
        mockProcessMessageEventArgs.Verify(x => x.AbandonMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<IDictionary<string, object>>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
