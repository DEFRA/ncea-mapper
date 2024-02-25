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
        ServiceBusServiceForTests.Get<JnccProcessor>(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<JnccProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var logger = new Logger<JnccProcessor>(new LoggerFactory());
        // Act
        var jnccService = new JnccProcessor(mockServiceBusService.Object, logger, appSettings);
        await jnccService.Process();

        // Assert
        mockServiceBusService.Verify(x => x.CreateProcessor(It.IsAny<Func<string, Task>>()), Times.Once);
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Process_ShouldNotSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<JnccProcessor>(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<JnccProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        // Act
        var jnccService = new JnccProcessor(mockServiceBusService.Object, loggerMock.Object, appSettings);
        await jnccService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task HandleMessage_ShouldSendMessagesToServiceBus()
    {
        //Arrange
        ServiceBusServiceForTests.Get<JnccProcessor>(out MapperConfigurations appSettings,
                                    out Mock<ServiceBusClient> mockServiceBusClient,
                                    out Mock<IServiceBusService> mockServiceBusService,
                                    out Mock<ILogger<JnccProcessor>> loggerMock,
                                    out Mock<ServiceBusSender> mockServiceBusSender,
                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var jnccService = new JnccProcessor(mockServiceBusService.Object, loggerMock.Object, appSettings);
        var handleMessageMethod = typeof(JnccProcessor).GetMethod("HandleMessage", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var task = (Task)handleMessageMethod?.Invoke(jnccService, new object[] { "test-param" });


        // Act
        await task;


        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Information,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
        mockServiceBusService.Verify(x => x.SendMessageAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    //[Fact]
    //public async Task HandleMessage_ShouldSendMessagesToServiceBus()
    //{
    //    //Arrange
    //    var serviceBusService = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender> mockServiceBusSender,
    //                                                          out Mock<ServiceBusProcessor> mockServiceBusProcessor);
    //    var expectedData = "<html><body><a href=\"a.xml\">a</a><a href=\"b.xml\">b</a></body></html>";
    //    var httpResponse = new HttpResponseMessage
    //    {
    //        StatusCode = HttpStatusCode.OK,
    //        Content = new StringContent(expectedData),
    //    };
    //    var apiClient = ApiClientForTests.Get(httpResponse);
    //    var appSettings = Options.Create(new MapperConfigurations() { Processor = new Processor() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Jncc, Type = "" } });
    //    var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
    //                                          out Mock<BlobContainerClient> mockBlobContainerClient,
    //                                          out Mock<BlobClient> mockBlobClient);
    //    var mockLogger = new Mock<ILogger<JnccProcessor>>(MockBehavior.Strict);
    //    mockLogger.Setup(x => x.Log(
    //            LogLevel.Information,
    //            It.IsAny<EventId>(),
    //            It.IsAny<It.IsAnyType>(),
    //            It.IsAny<Exception>(),
    //            It.IsAny<Func<It.IsAnyType, Exception?, string>>()
    //        )
    //    );

    //    // Act
    //    var jnccService = new JnccProcessor(apiClient, serviceBusService, blobService, mockLogger.Object, appSettings);
    //    await jnccService.HandleMessage("test-message");

    //    // Assert
    //    mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), default), Times.Exactly(1));
    //    mockLogger.Verify(
    //        m => m.Log(
    //            LogLevel.Information,
    //            It.IsAny<EventId>(),
    //            It.IsAny<It.IsAnyType>(),
    //            It.IsAny<Exception>(),
    //            It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
    //        Times.Exactly(2),
    //        It.IsAny<string>()
    //    );

    //}
}
