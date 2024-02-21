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

public class MedinProcessorTests
{
    [Fact]
    public async Task Process_ShouldSendMessagesToServiceBus()
    {
        //Arrange
        var serviceBusService = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender> mockServiceBusSender,
                                                              out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var expectedData = "<html><body><a href=\"a.xml\">a</a><a href=\"b.xml\">b</a></body></html>";
        var httpResponse = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(expectedData),
        };
        var apiClient = ApiClientForTests.Get(httpResponse);
        var appSettings = Options.Create(new MapperConfigurations() { Processor = new Processor() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Medin, Type = "" } });
        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);
        var logger = new Logger<MedinProcessor>(new LoggerFactory());
        
        // Act
        var medinService = new MedinProcessor(apiClient, serviceBusService, blobService, logger, appSettings);
        await medinService.Process();

        // Assert
        //mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), default), Times.Exactly(2));
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task Process_ShouldNotSendMessagesToServiceBus()
    {
        //Arrange
        var serviceBusService = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender> mockServiceBusSender,
                                                              out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var expectedData = "<html><body></body></html>";
        var httpResponse = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(expectedData),
        };
        var apiClient = ApiClientForTests.Get(httpResponse);
        var appSettings = Options.Create(new MapperConfigurations() { Processor = new Processor() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Medin, Type = "" } });
        var blobServiceMock = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                                      out Mock<BlobContainerClient> mockBlobContainerClient,
                                                      out Mock<BlobClient> mockBlobClient);
        var loggerMock = new Mock<ILogger<MedinProcessor>>();

        // Act
        var medinService = new MedinProcessor(apiClient, serviceBusService, blobServiceMock, loggerMock.Object, appSettings);
        await medinService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task HandleMessage_ShouldSendMessagesToServiceBus()
    {
        //Arrange
        var serviceBusService = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender> mockServiceBusSender,
                                                              out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var expectedData = "<html><body><a href=\"a.xml\">a</a><a href=\"b.xml\">b</a></body></html>";
        var httpResponse = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.OK,
            Content = new StringContent(expectedData),
        };
        var apiClient = ApiClientForTests.Get(httpResponse);
        var appSettings = Options.Create(new MapperConfigurations() { Processor = new Processor() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Medin, Type = "" } });
        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);
        var mockLogger = new Mock<ILogger<MedinProcessor>>(MockBehavior.Strict);
        mockLogger.Setup(x => x.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()
            )
        );

        // Act
        var medinService = new MedinProcessor(apiClient, serviceBusService, blobService, mockLogger.Object, appSettings);
        await medinService.HandleMessage("test-message");

        // Assert
        mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), default), Times.Exactly(1));
        mockLogger.Verify(
            m => m.Log(
                LogLevel.Information,
                It.IsAny<EventId>(),
                It.IsAny<It.IsAnyType>(),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception?, string>>()),
            Times.Exactly(2),
            It.IsAny<string>()
        );

    }
}
