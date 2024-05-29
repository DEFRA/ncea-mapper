using FluentAssertions;
using Ncea.Mapper.Services;
using System.Xml;

namespace Ncea.Mapper.Tests.Services;

public class ValidationServiceTests
{
    [Fact]
    public void IsValid_WhenXmlNodeCountNnBothSourceAndTargetIsSame_ThenReturnTrue()
    {
        //Arrange
        var validsationService = new ValidationService();
        
        var sourceFilePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "JNCC_Metadata.xml");
        var xDocSource = new XmlDocument();
        xDocSource.Load(sourceFilePath);
        var sourceXml = xDocSource.InnerXml;

        var targetFilePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "JNCC_Metadata.xml");
        var xDocTarget = new XmlDocument();
        xDocTarget.Load(targetFilePath);
        var targetXml = xDocTarget.InnerXml;

        //Act
        var result = validsationService.IsValid(sourceXml, targetXml);

        //Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void IsValid_WhenXmlNodeCountOnBothSourceAndTargetIsNotSame_ThenReturnFalse()
    {
        //Arrange
        var validsationService = new ValidationService();

        var sourceFilePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "JNCC_Metadata.xml");
        var xDocSource = new XmlDocument();
        xDocSource.Load(sourceFilePath);
        var sourceXml = xDocSource.InnerXml;

        var targetFilePath = Path.Combine(Directory.GetCurrentDirectory(), "TestData", "JNCC_Metadata_With_Missing_Fields.xml");
        var xDocTarget = new XmlDocument();
        xDocTarget.Load(targetFilePath);
        var targetXml = xDocTarget.InnerXml;

        //Act
        var result = validsationService.IsValid(sourceXml, targetXml);

        //Assert
        result.Should().BeFalse();
    }
}
