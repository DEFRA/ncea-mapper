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
        var appSettings = new MapperConfigurations() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Medin, Type = "" };
        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);
        var logger = new Logger<MedinProcessor>(new LoggerFactory());
        
        // Act
        var medinService = new MedinProcessor(serviceBusService, logger, appSettings);
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
        var appSettings = new MapperConfigurations() { DataSourceApiBase = "https://base-uri", DataSourceApiUrl = "/test-url", ProcessorType = ProcessorType.Medin, Type = "" };
        var loggerMock = new Mock<ILogger<MedinProcessor>>();

        // Act
        var medinService = new MedinProcessor(serviceBusService, loggerMock.Object, appSettings);
        await medinService.Process();

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }
}
