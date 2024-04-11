using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using ncea.mapper.Processor;
using ncea.mapper.Processor.Contracts;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;
using System.Reflection;
using System.Xml.Linq;

namespace Ncea.Mapper.Tests.Processors;

public class MedinMapperTests
{
    [Fact]
    public async Task Process_ShouldLogMessage()
    {
        //Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var medinService = new MedinMapper(loggerMock.Object);
        var messageBody = "<?xml version=\"1.0\"?><gmd:MD_Metadata xmlns:gss=\"http://www.isotc211.org/2005/gss\" xmlns:gsr=\"http://www.isotc211.org/2005/gsr\" xmlns:gco=\"http://www.isotc211.org/2005/gco\" xmlns:gml=\"http://www.opengis.net/gml/3.2\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:gts=\"http://www.isotc211.org/2005/gts\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:srv=\"http://www.isotc211.org/2005/srv\" xmlns:gmx=\"http://www.isotc211.org/2005/gmx\" xmlns:gmd=\"http://www.isotc211.org/2005/gmd\"><gmd:fileIdentifier>\r\n    <gco:CharacterString>test-field-identifier</gco:CharacterString>\r\n  </gmd:fileIdentifier></gmd:MD_Metadata>";


        // Act
        await medinService.Transform("mdcNamespaceStr", messageBody, It.IsAny<CancellationToken>());


        // Assert
        loggerMock.Verify(x => x.Log(LogLevel.Information,
            It.IsAny<EventId>(),
            It.IsAny<It.IsAnyType>(),
            It.IsAny<Exception>(),
            It.IsAny<Func<It.IsAnyType, Exception?, string>>()), Times.Once);
    }

    [Fact]
    public void GetFileIdentifierMethod_ShouldReturnFieldIdentifier()
    {
        //Arrange
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var medinService = new MedinMapper(loggerMock.Object);
        var fieldIdentifierTestValue = "test-field-identifier";
        var metadataXml = "<?xml version=\"1.0\"?><gmd:MD_Metadata xmlns:gss=\"http://www.isotc211.org/2005/gss\" xmlns:gsr=\"http://www.isotc211.org/2005/gsr\" xmlns:gco=\"http://www.isotc211.org/2005/gco\" xmlns:gml=\"http://www.opengis.net/gml/3.2\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:gts=\"http://www.isotc211.org/2005/gts\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:srv=\"http://www.isotc211.org/2005/srv\" xmlns:gmx=\"http://www.isotc211.org/2005/gmx\" xmlns:gmd=\"http://www.isotc211.org/2005/gmd\"><gmd:fileIdentifier>\r\n    <gco:CharacterString>" + fieldIdentifierTestValue + "</gco:CharacterString>\r\n  </gmd:fileIdentifier></gmd:MD_Metadata>";


        // Act
        var GetFileIdentifierMethod = typeof(MedinMapper).GetMethod("GetFileIdentifier", BindingFlags.NonPublic | BindingFlags.Static);
        var responseXml = XDocument.Parse(metadataXml);
        var rootNode = responseXml.Root;
        var fieldIdentifier = (string?)GetFileIdentifierMethod?.Invoke(medinService, new object[] { rootNode! });

        // Assert
        Assert.Equal(fieldIdentifierTestValue, fieldIdentifier);
    }
}