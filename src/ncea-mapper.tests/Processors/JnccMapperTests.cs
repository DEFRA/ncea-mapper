using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using ncea.mapper.Processor.Contracts;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;

namespace Ncea.Mapper.Tests.Processors;

public class JnccMapperTests
{
    [Fact]
    public async Task Process_ShouldLogMessage()
    {
        //Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<JnccMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var jnccService = new JnccMapper(loggerMock.Object);



        // Act
        await jnccService.Transform(It.IsAny<string>(), It.IsAny<CancellationToken>());


        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Information,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
    }
}
