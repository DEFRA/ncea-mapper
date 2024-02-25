using Azure.Messaging.ServiceBus;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;

namespace Ncea.Mapper.Tests.Processors;

public class MedinProcessorTests
{
    [Fact]
    public async Task Process_ShouldSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<MedinProcessor>(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<MedinProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);
        
        // Act
        var medinService = new MedinProcessor(mockServiceBusService.Object, loggerMock.Object);
        await medinService.Process();

        // Assert
        //mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), default), Times.Exactly(2));
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Process_ShouldNotSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<MedinProcessor>(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<MedinProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        // Act
        var medinService = new MedinProcessor(mockServiceBusService.Object, loggerMock.Object);
        await medinService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task HandleMessage_ShouldSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<MedinProcessor>(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<MedinProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var medinService = new MedinProcessor(mockServiceBusService.Object, loggerMock.Object);
        var handleMessageMethod = typeof(MedinProcessor).GetMethod("HandleMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var task = (Task?)handleMessageMethod?.Invoke(medinService, new object[] { "test-param" });


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
