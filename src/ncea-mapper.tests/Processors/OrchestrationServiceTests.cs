using Azure.Messaging.ServiceBus;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Harvester.Tests.Clients;
using Ncea.mapper.Infrastructure.Contracts;
using Ncea.Mapper.Infrastructure.Models.Requests;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processor;
using Ncea.Mapper.Processor.Contracts;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;
using ncea_mapper.tests.Clients;
using System.Reflection;
using System.Text.Json;

namespace Ncea.Mapper.Tests.Processors;

public class OrchestrationServiceTests
{
    [Fact]
    public async Task StartProcessorAsync_ShouldStartProcessorAsyncOnServiceBusProcessor()
    {
        // Arrange
        OrchestrationServiceForTests.Get<OrchestrationService>(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);

        var serviceProvider = new Mock<IServiceProvider>();
        var service = new OrchestrationService(configuration, blobService, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, serviceProvider.Object, loggerMock.Object);

        // Act
        await service.StartProcessorAsync(It.IsAny<CancellationToken>());

        // Assert
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task CreateProcessor_ShouldCall_CreateProcessor_On_ServiceBusClient()
    {
        // Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);
        var mockServiceProvider = new Mock<IServiceProvider>();

        // Act
        var service = new OrchestrationService(configuration, blobService, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, mockServiceProvider.Object, loggerMock.Object);
        await service.StartProcessorAsync(It.IsAny<CancellationToken>());

        // Assert        
        mockServiceBusProcessor.Verify(x => x.StartProcessingAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task ErrorHandlerAsync_Should_Complete_Task()
    {
        // Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);

        var mockServiceProvider = new Mock<IServiceProvider>();

        var service = new OrchestrationService(configuration, blobService, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, mockServiceProvider.Object, loggerMock.Object);
        var args = new ProcessErrorEventArgs(new Exception("test-exception"), It.IsAny<ServiceBusErrorSource>(),
                                             It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                                             It.IsAny<CancellationToken>());
        var errorHandlerMethod = typeof(OrchestrationService).GetMethod("ErrorHandlerAsync", BindingFlags.NonPublic | BindingFlags.Instance);
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
    public async Task ProcessMessagesAsync_WhenReceivedForMedinDataSource_ThenCompleteMessageAsync()
    {
        // Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        LoggerForTests.Get<MedinMapper>(out Mock<ILogger<MedinMapper>> mockLogger);

        var blobContent = "<?xml version=\"1.0\"?><gmd:MD_Metadata xmlns:gss=\"http://www.isotc211.org/2005/gss\" xmlns:gsr=\"http://www.isotc211.org/2005/gsr\" xmlns:gco=\"http://www.isotc211.org/2005/gco\" xmlns:gml=\"http://www.opengis.net/gml/3.2\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:gts=\"http://www.isotc211.org/2005/gts\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:srv=\"http://www.isotc211.org/2005/srv\" xmlns:gmx=\"http://www.isotc211.org/2005/gmx\" xmlns:gmd=\"http://www.isotc211.org/2005/gmd\"><gmd:fileIdentifier>\r\n    <gco:CharacterString>test-field-identifier</gco:CharacterString>\r\n  </gmd:fileIdentifier></gmd:MD_Metadata>";

        var blobServiceMock = new Mock<IBlobService>();
        blobServiceMock.Setup(x => x.GetContentAsync(It.IsAny<GetBlobContentRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(blobContent);
        blobServiceMock.Setup(x => x.SaveAsync(It.IsAny<SaveBlobRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(It.IsAny<string>());

        var messageBody = "{ \"FileIdentifier\":\"\",\"DataFormat\":\"xml\",\"DataStandard\":\"Gemini23\",\"DataSource\":\"Medin\"}";

        
        var receivedMessage = ServiceBusModelFactory.ServiceBusReceivedMessage(body: new BinaryData(messageBody), messageId: "messageId");
        var mockReceiver = new Mock<ServiceBusReceiver>();
        var processMessageEventArgs = new ProcessMessageEventArgs(receivedMessage, It.IsAny<ServiceBusReceiver>(), It.IsAny<CancellationToken>());
        var mockProcessMessageEventArgs = new Mock<ProcessMessageEventArgs>(MockBehavior.Strict, new object[] { receivedMessage, mockReceiver.Object, It.IsAny<string>(), It.IsAny<CancellationToken>() });
        mockProcessMessageEventArgs.Setup(receiver => receiver.CompleteMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        var mockServiceProvider = ServiceProviderForTests.Get();

        // Act
        var service = new OrchestrationService(configuration, blobServiceMock.Object, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, mockServiceProvider, loggerMock.Object);
        var processMessagesAsyncMethod = typeof(OrchestrationService).GetMethod("ProcessMessagesAsync", BindingFlags.NonPublic | BindingFlags.Instance);
        var task = (Task?)(processMessagesAsyncMethod?.Invoke(service, new object[] { mockProcessMessageEventArgs.Object }));
        if (task != null) await task;

        // Assert
        mockProcessMessageEventArgs.Verify(x => x.CompleteMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task ProcessMessagesAsync_WhenReceivedForJnccDataSource_ThenCompleteMessageAsync()
    {
        // Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        LoggerForTests.Get<JnccMapper>(out Mock<ILogger<JnccMapper>> mockLogger);

        var blobContent = "<?xml version=\"1.0\"?><gmd:MD_Metadata xmlns:gss=\"http://www.isotc211.org/2005/gss\" xmlns:gsr=\"http://www.isotc211.org/2005/gsr\" xmlns:gco=\"http://www.isotc211.org/2005/gco\" xmlns:gml=\"http://www.opengis.net/gml/3.2\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:gts=\"http://www.isotc211.org/2005/gts\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:srv=\"http://www.isotc211.org/2005/srv\" xmlns:gmx=\"http://www.isotc211.org/2005/gmx\" xmlns:gmd=\"http://www.isotc211.org/2005/gmd\"><gmd:fileIdentifier>\r\n    <gco:CharacterString>test-field-identifier</gco:CharacterString>\r\n  </gmd:fileIdentifier></gmd:MD_Metadata>";
        
        var blobServiceMock = new Mock<IBlobService>();
        blobServiceMock.Setup(x => x.GetContentAsync(It.IsAny<GetBlobContentRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(blobContent);
        blobServiceMock.Setup(x => x.SaveAsync(It.IsAny<SaveBlobRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(It.IsAny<string>());

        var messageBody = "{ \"FileIdentifier\":\"\",\"DataFormat\":\"xml\",\"DataStandard\":\"Gemini23\",\"DataSource\":\"Jncc\"}";

        var receivedMessage = ServiceBusModelFactory.ServiceBusReceivedMessage(body: new BinaryData(messageBody), messageId: "messageId");
        var mockReceiver = new Mock<ServiceBusReceiver>();
        var processMessageEventArgs = new ProcessMessageEventArgs(receivedMessage, It.IsAny<ServiceBusReceiver>(), It.IsAny<CancellationToken>());
        var mockProcessMessageEventArgs = new Mock<ProcessMessageEventArgs>(MockBehavior.Strict, new object[] { receivedMessage, mockReceiver.Object, It.IsAny<string>(), It.IsAny<CancellationToken>() });
        mockProcessMessageEventArgs.Setup(receiver => receiver.CompleteMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        var mockServiceProvider = ServiceProviderForTests.Get();

        // Act
        var service = new OrchestrationService(configuration, blobServiceMock.Object, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, mockServiceProvider, loggerMock.Object);
        var processMessagesAsyncMethod = typeof(OrchestrationService).GetMethod("ProcessMessagesAsync", BindingFlags.NonPublic | BindingFlags.Instance);
        var task = (Task?)(processMessagesAsyncMethod?.Invoke(service, new object[] { mockProcessMessageEventArgs.Object }));
        if (task != null) await task;

        // Assert
        mockProcessMessageEventArgs.Verify(x => x.CompleteMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task ProcessMessagesAsync_WithError_Should_AbandonMessageAsync()
    {
        // Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);

        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);

        var receivedMessage = ServiceBusModelFactory.ServiceBusReceivedMessage(body: null, messageId: "messageId");
        var mockReceiver = new Mock<ServiceBusReceiver>();
        var processMessageEventArgs = new ProcessMessageEventArgs(receivedMessage, It.IsAny<ServiceBusReceiver>(), It.IsAny<CancellationToken>());
        var mockProcessMessageEventArgs = new Mock<ProcessMessageEventArgs>(MockBehavior.Strict, new object[] { receivedMessage, mockReceiver.Object, It.IsAny<string>(), It.IsAny<CancellationToken>() });
        mockProcessMessageEventArgs.Setup(x => x.AbandonMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<IDictionary<string, object>>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        var mockServiceProvider = new Mock<IServiceProvider>();
        
        // Act
        var service = new OrchestrationService(configuration, blobService, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, mockServiceProvider.Object, loggerMock.Object);
        var processMessagesAsyncMethod = typeof(OrchestrationService).GetMethod("ProcessMessagesAsync", BindingFlags.NonPublic | BindingFlags.Instance);
        var task = (Task?)(processMessagesAsyncMethod?.Invoke(service, new object[] { mockProcessMessageEventArgs.Object }));
        if (task != null) await task;

        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Error,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
        mockProcessMessageEventArgs.Verify(x => x.AbandonMessageAsync(It.IsAny<ServiceBusReceivedMessage>(), It.IsAny<IDictionary<string, object>>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task SendMessageAsync_Should_SendMessageAsync_On_ServiceBusSender()
    {
        // Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<OrchestrationService>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var blobService = BlobServiceForTests.Get(out Mock<BlobServiceClient> mockBlobServiceClient,
                                              out Mock<BlobContainerClient> mockBlobContainerClient,
                                              out Mock<BlobClient> mockBlobClient);
        var mockServiceProvider = new Mock<IServiceProvider>();
        
        
        // Act
        var service = new OrchestrationService(configuration, blobService, mockServiceBusSenderFactory.Object, mockServiceBusProcessorFactory.Object, mockServiceProvider.Object, loggerMock.Object);
        var processMessagesAsyncMethod = typeof(OrchestrationService).GetMethod("SendMessageAsync", BindingFlags.NonPublic | BindingFlags.Instance);
        var task = (Task?)(processMessagesAsyncMethod?.Invoke(service, new object[] { "test-message", It.IsAny<CancellationToken>() }));
        if (task != null) await task;

        // Assert
        mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
