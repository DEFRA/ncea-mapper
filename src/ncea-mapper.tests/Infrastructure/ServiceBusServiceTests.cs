using Azure.Messaging.ServiceBus;
using Moq;
using Ncea.Mapper.Tests.Clients;

namespace Ncea.Mapper.Tests.Infrastructure;

public class ServiceBusServiceTests
{
    [Fact]
    public async Task SendMessage_ShouldSendMessageToQueue()
    {
        // Arrange
        var service = ServiceBusServiceForTests.Get(out Mock<ServiceBusSender>  mockServiceBusSender,
                                                    out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        
        // Act
        await service.SendMessageAsync("Hello, World!");

        // Assert
        mockServiceBusSender.Verify(x => x.SendMessageAsync(It.IsAny<ServiceBusMessage>(), default), Times.Once);
    }
}
