﻿using AutoMapper;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Mapper.AutoMapper;
using Ncea.Mapper.Processor.Contracts;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;
using System.Xml;
using Ncea.Mapper.Extensions;
using ncea_mapper.tests.Clients;
using Microsoft.Extensions.DependencyInjection;
using Ncea.mapper.Infrastructure.Contracts;
using Ncea.Mapper.BusinessExceptions;

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

    [Fact]
    public async Task Process_InValidMetadata_ThrowsXmlValidationException()
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

        var jnccService = new JnccMapper(mapper);
        var messageBody = "<?xml version=\"1.0\"?><gmd:MD_Metadata xmlns:gss=\"http://www.isotc211.org/2005/gss\" xmlns:gsr=\"http://www.isotc211.org/2005/gsr\" xmlns:gco=\"http://www.isotc211.org/2005/gco\" xmlns:gml=\"http://www.opengis.net/gml/3.2\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:gts=\"http://www.isotc211.org/2005/gts\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:srv=\"http://www.isotc211.org/2005/srv\" xmlns:gmx=\"http://www.isotc211.org/2005/gmx\" xmlns:gmd=\"http://www.isotc211.org/2005/gmd\"><gmd:fileIdentifier>\r\n    <gco:CharacterString>test-field-identifier</gco:CharacterString>\r\n  </gmd:fileIdentifier><test>Test Node</test></gmd:MD_Metadata>";


        // Act
        var task = jnccService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());


        // Assert
        await Assert.ThrowsAsync<XmlValidationException>(() => task!);
    }

}
