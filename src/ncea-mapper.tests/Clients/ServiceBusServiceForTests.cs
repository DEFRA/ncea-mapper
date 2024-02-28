using Moq;
using Azure.Messaging.ServiceBus;
using Ncea.Mapper.Models;
using Ncea.Mapper.Constants;
using Microsoft.Extensions.Logging;
using ncea.mapper.Processor.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Azure;

namespace Ncea.Mapper.Tests.Clients;

public static class ServiceBusServiceForTests
{
    public static void Get<T>(out Mock<IConfiguration> mockConfiguration,
        out Mock<IAzureClientFactory<ServiceBusSender>> mockAzureServiceBusSenderFactory,
        out Mock<IAzureClientFactory<ServiceBusProcessor>> mockAzureServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<T>> loggerMock)
    {

        mockConfiguration = new Mock<IConfiguration>();
        mockConfiguration.Setup(c => c.GetSection(It.IsAny<String>())).Returns(new Mock<IConfigurationSection>().Object);
        mockConfiguration.SetupGet(x => x[It.IsAny<string>()]).Returns("the string you want to return");

        mockAzureServiceBusSenderFactory = new Mock<IAzureClientFactory<ServiceBusSender>>();
        mockAzureServiceBusSenderFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
            .Returns<ServiceBusSender>(res =>
            {
                var mockAzureSend = new Mock<ServiceBusSender>();
                mockAzureSend
                    .Setup(y => y.SendMessageAsync(It.IsAny<ServiceBusMessage>(), It.IsAny<CancellationToken>()))
                    .Returns(Task.FromResult(default(object)));

                return mockAzureSend.Object;
            }
            );

        mockAzureServiceBusProcessorFactory = new Mock<IAzureClientFactory<ServiceBusProcessor>>();
        mockAzureServiceBusProcessorFactory.Setup(x => x.CreateClient(It.IsAny<string>()))
            .Returns<ServiceBusProcessor>(res =>
            {
                var mockAzureSend = new Mock<ServiceBusProcessor>();
                mockAzureSend
                    .Setup(y => y.StartProcessingAsync(It.IsAny<CancellationToken>()))
                    .Returns(Task.FromResult(default(object)));

                return mockAzureSend.Object;
            }
            );

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
        mockOrchestrationService.Setup(x => x.StartProcessorAsync(It.IsAny<CancellationToken>())).Returns(Task.CompletedTask);
    }
}
