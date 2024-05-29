using AutoMapper;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;
using System.Xml;
using Ncea.Mapper.Extensions;
using ncea_mapper.tests.Clients;
using Microsoft.Extensions.DependencyInjection;
using Ncea.Mapper.Processor.Contracts;

namespace Ncea.Mapper.Tests.Processors;

public class JnccMapperTests
{
    [Fact]
    public async Task Process_ValidateMdcFields_For_Jncc_Dataset_Metadata()
    {
        //Arrange
        var mdcNamespaceStr = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139/src/main/plugin/iso19139/schema2007/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<JnccMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        ////Create Auto mapper object
        //var mappingProfile = new MappingProfile();
        //var mappingConfig = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
        //var mapper = new AutoMapper.Mapper(mappingConfig);

        var jnccService = new JnccMapper(mapper);

        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "JNCC_Metadata.xml");
        var xDoc = new XmlDocument();
        xDoc.Load(filePath);
        var messageBody = xDoc.InnerXml;


        // Act
        var mdcMetadataStr = await jnccService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());
        var gemini22Metadata = messageBody.Deserialize<Gemini22MdMetadata>();
        var mdcMetadata = mdcMetadataStr.Deserialize<MdcMdMetadata>();

        // Assert
        Assert.Equal(gemini22Metadata?.Language.LanguageCode.CodeListValue, mdcMetadata?.Language.LanguageCode.CodeListValue);
        Assert.NotNull(mdcMetadata?.nceaClassifierInfo);
        Assert.True(mdcMetadata?.nceaIdentifiers?.MasterReferenceID?.sourceSystemReferenceID?.CharacterString?.StartsWith("jncc", StringComparison.OrdinalIgnoreCase));
    }

}
