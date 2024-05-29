﻿using AutoMapper;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.mapper.Infrastructure.Contracts;
using Ncea.Mapper.AutoMapper;
using Ncea.Mapper.BusinessExceptions;
using Ncea.Mapper.Extensions;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processor.Contracts;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Tests.Clients;
using ncea_mapper.tests.Clients;
using System.Threading.Tasks;
using System.Xml;

namespace Ncea.Mapper.Tests.Processors;

public class MedinMapperTests
{
    [Fact]
    public async Task Process_ValidateMdcFields_For_Medin_Dataset_Metadata()
    {
        //Arrange
        var mdcNamespaceStr = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139/src/main/plugin/iso19139/schema2007/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();


        var medinService = new MedinMapper(mapper);

        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "MEDIN_Metadata_dataset_v3_1_2_example.xml");
        var xDoc = new XmlDocument();
        xDoc.Load(filePath);
        var messageBody = xDoc.InnerXml;


        // Act
        var mdcMetadataStr = await medinService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());
        var gemini23Metadata = messageBody.Deserialize<Gemini23MdMetadata>();
        var mdcMetadata = mdcMetadataStr.Deserialize<MdcMdMetadata>();

        // Assert
        Assert.Equal(gemini23Metadata?.MetadataStandardVersion.CharacterString, mdcMetadata?.MetadataStandardVersion.CharacterString);
        Assert.Equal(gemini23Metadata?.MetadataStandardName.CharacterString, mdcMetadata?.MetadataStandardName.CharacterString);
        Assert.Equal(gemini23Metadata?.Language.LanguageCode.CodeListValue, mdcMetadata?.Language.LanguageCode.CodeListValue);
        Assert.NotNull(mdcMetadata?.nceaClassifierInfo);
        Assert.True(mdcMetadata?.nceaIdentifiers?.MasterReferenceID?.sourceSystemReferenceID?.CharacterString?.StartsWith("medin", StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public async Task Process_ValidateMdcFields_For_Medin_Series_Metadata()
    {
        //Arrange
        var mdcNamespaceStr = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139/src/main/plugin/iso19139/schema2007/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        var medinService = new MedinMapper(mapper);
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "MEDIN_Metadata_series_v3_1_2_example.xml");
        var xDoc = new XmlDocument();
        xDoc.Load(filePath);
        var messageBody = xDoc.InnerXml;

        // Act        
        var mdcMetadataStr = await medinService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());
        var gemini23Metadata = messageBody.Deserialize<Gemini23MdMetadata>();
        var mdcMetadata = mdcMetadataStr.Deserialize<MdcMdMetadata>();


        // Assert
        Assert.Equal(gemini23Metadata?.MetadataStandardVersion.CharacterString, mdcMetadata?.MetadataStandardVersion.CharacterString);
        Assert.Equal(gemini23Metadata?.MetadataStandardName.CharacterString, mdcMetadata?.MetadataStandardName.CharacterString);
        Assert.Equal(gemini23Metadata?.Language.LanguageCode.CodeListValue, mdcMetadata?.Language.LanguageCode.CodeListValue);
        Assert.NotNull(mdcMetadata?.nceaClassifierInfo);
        Assert.True(mdcMetadata?.nceaIdentifiers?.MasterReferenceID?.sourceSystemReferenceID?.CharacterString?.StartsWith("medin", StringComparison.OrdinalIgnoreCase));
    }

    [Fact]
    public async Task Process_ValidateMdcFields_For_Medin_Service_Metadata()
    {
        //Arrange
        var mdcNamespaceStr = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139/src/main/plugin/iso19139/schema2007/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        var medinService = new MedinMapper(mapper);
        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "MEDIN_Metadata_srv_v3_1_2_example.xml");
        var xDoc = new XmlDocument();
        xDoc.Load(filePath);
        var messageBody = xDoc.InnerXml;


        // Act
        var mdcMetadataStr = await medinService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());
        var gemini23Metadata = messageBody.Deserialize<Gemini23MdMetadata>();
        var mdcMetadata = mdcMetadataStr.Deserialize<MdcMdMetadata>();


        // Assert
        Assert.Equal(gemini23Metadata?.IdentificationInfo.SV_ServiceIdentification.ServiceType.LocalName.Text, mdcMetadata?.IdentificationInfo.SV_ServiceIdentification.ServiceType.LocalName.Text);
        Assert.Equal(gemini23Metadata?.IdentificationInfo.SV_ServiceIdentification.OperatesOn[0].Title, mdcMetadata?.IdentificationInfo.SV_ServiceIdentification.OperatesOn[0].Title);
        Assert.NotNull(mdcMetadata?.nceaClassifierInfo);
        Assert.True(mdcMetadata?.nceaIdentifiers?.MasterReferenceID?.sourceSystemReferenceID?.CharacterString?.StartsWith("medin", StringComparison.OrdinalIgnoreCase));
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
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        var medinService = new MedinMapper(mapper);
        var messageBody = "<?xml version=\"1.0\"?><gmd:MD_Metadata xmlns:gss=\"http://www.isotc211.org/2005/gss\" xmlns:gsr=\"http://www.isotc211.org/2005/gsr\" xmlns:gco=\"http://www.isotc211.org/2005/gco\" xmlns:gml=\"http://www.opengis.net/gml/3.2\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" xmlns:gts=\"http://www.isotc211.org/2005/gts\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:srv=\"http://www.isotc211.org/2005/srv\" xmlns:gmx=\"http://www.isotc211.org/2005/gmx\" xmlns:gmd=\"http://www.isotc211.org/2005/gmd\"><gmd:fileIdentifier>\r\n    <gco:CharacterString>test-field-identifier</gco:CharacterString>\r\n  </gmd:fileIdentifier><test>Test Node</test></gmd:MD_Metadata>";


        // Act
        var task = medinService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());


        // Assert
        await Assert.ThrowsAsync<XmlValidationException>(() => task!);
    }
}