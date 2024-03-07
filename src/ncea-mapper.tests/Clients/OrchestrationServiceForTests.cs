using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using ncea.mapper.Processor.Contracts;

namespace Ncea.Mapper.Tests.Clients;

public static class OrchestrationServiceForTests
{
    public static void Get<T>(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<T>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor)
    {
        List<KeyValuePair<string, string?>> lstProps = new List<KeyValuePair<string, string?>>();
        lstProps.Add(new KeyValuePair<string, string?>("HarvesterQueueName", "test-HarvesterQueueName"));
        lstProps.Add(new KeyValuePair<string, string?>("MapperQueueName", "test-MapperQueueName"));

        configuration = new ConfigurationBuilder()
                            .AddInMemoryCollection(lstProps)
                            .Build();
        mockServiceBusSenderFactory = new Mock<IAzureClientFactory<ServiceBusSender>>();
        mockServiceBusProcessorFactory = new Mock<IAzureClientFactory<ServiceBusProcessor>>();


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
        mockOrchestrationService = new Mock<IOrchestrationService>();

        // Set up the mock to return the mock sender        
        mockServiceBusProcessor.Setup(x => x.StartProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        mockOrchestrationService.Setup(x => x.StartProcessorAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        mockServiceBusProcessor.Setup(x => x.StopProcessingAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        mockServiceBusSender.Setup(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
        mockServiceBusSenderFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(mockServiceBusSender.Object);
        mockServiceBusProcessorFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(mockServiceBusProcessor.Object);
    }
}
