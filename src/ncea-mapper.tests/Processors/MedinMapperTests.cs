using AutoMapper;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Moq;
using Ncea.Mapper.Extensions;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processor.Contracts;
using Ncea.Mapper.Processors;
using Ncea.Mapper.Services.Contracts;
using Ncea.Mapper.Tests.Clients;
using System.Xml;
using System.Xml.Schema;

namespace Ncea.Mapper.Tests.Processors;

public class MedinMapperTests
{
    [Fact]
    public async Task Process_ValidateMdcFields_For_Medin_Dataset_Metadata()
    {
        //Arrange
        var mdcNamespaceStr = "https://ncea-search.azure.defra.cloud/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        //Create Auto mapper object
        //var mappingProfile = new MappingProfile();
        //var mappingConfig = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
        //var mapper = new AutoMapper.Mapper(mappingConfig);

        var validationServiceMock = new Mock<IValidationService>();
        validationServiceMock.Setup(x => x.IsValid(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        var medinService = new MedinMapper(mapper, validationServiceMock.Object);

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
        var mdcNamespaceStr = "https://ncea-search.azure.defra.cloud/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        var validationServiceMock = new Mock<IValidationService>();
        validationServiceMock.Setup(x => x.IsValid(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        //Create Auto mapper object
        //var mappingProfile = new MappingProfile();
        //var mappingConfig = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
        //var mapper = new AutoMapper.Mapper(mappingConfig);

        var medinService = new MedinMapper(mapper, validationServiceMock.Object);
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
        var mdcNamespaceStr = "https://ncea-search.azure.defra.cloud/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        var validationServiceMock = new Mock<IValidationService>();
        validationServiceMock.Setup(x => x.IsValid(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(true);

        //Create Auto mapper object
        //var mappingProfile = new MappingProfile();
        //var mappingConfig = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
        //var mapper = new AutoMapper.Mapper(mappingConfig);

        var medinService = new MedinMapper(mapper, validationServiceMock.Object);
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
    public async Task Transform_WhenDataLossOccurs_ThenThrowXmlSchemaValidationException()
    {
        //Arrange
        var mdcNamespaceStr = "https://ncea-search.azure.defra.cloud/mdc";
        OrchestrationServiceForTests.Get(out IConfiguration configuration,
                            out Mock<IAzureClientFactory<ServiceBusSender>> mockServiceBusSenderFactory,
                            out Mock<IAzureClientFactory<ServiceBusProcessor>> mockServiceBusProcessorFactory,
                            out Mock<IOrchestrationService> mockOrchestrationService,
                            out Mock<ILogger<MedinMapper>> loggerMock,
                            out Mock<ServiceBusSender> mockServiceBusSender,
                            out Mock<ServiceBusProcessor> mockServiceBusProcessor);
        var serviceProvider = ServiceProviderForTests.Get();
        var mapper = serviceProvider.GetRequiredService<IMapper>();

        //Create Auto mapper object
        //var mappingProfile = new MappingProfile();
        //var mappingConfig = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
        //var mapper = new AutoMapper.Mapper(mappingConfig);

        var validationServiceMock = new Mock<IValidationService>();
        validationServiceMock.Setup(x => x.IsValid(It.IsAny<string>(), It.IsAny<string>()))
            .Returns(false);

        var medinService = new MedinMapper(mapper, validationServiceMock.Object);

        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "MEDIN_Metadata_dataset_v3_1_2_example.xml");
        var xDoc = new XmlDocument();
        xDoc.Load(filePath);
        var messageBody = xDoc.InnerXml;

        // Act
        var task = medinService.Transform(mdcNamespaceStr, messageBody, It.IsAny<CancellationToken>());

        // Assert
        await Assert.ThrowsAsync<XmlSchemaValidationException>(() => task!);
    }
}