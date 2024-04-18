using Ncea.Mapper.Constants;
using Ncea.Mapper.Processors.Contracts;
using System.Xml.Linq;

namespace Ncea.Mapper.Processors;

public class MedinMapper : IMapperService
{    
    private readonly ILogger<MedinMapper> _logger;

    public MedinMapper(ILogger<MedinMapper> logger)
    {     
        _logger = logger;
    }
    public async Task<string> Transform(string mdcSchemaLocation, string harvestedData, CancellationToken cancellationToken = default)
    {
        var responseXml = XDocument.Parse(harvestedData);
        var rootNode = responseXml.Root;
        var fileIdentifier = GetFileIdentifier(rootNode!);
        if (rootNode != null)
        {
            XNamespace mdc = mdcSchemaLocation;
            var mdcNameSpaceAttribute = new XAttribute(XNamespace.Xmlns + "mdc", mdc.NamespaceName);
            rootNode!.Add(mdcNameSpaceAttribute);
            var nceaIdentifiersNode = CreateNceaIdentifiersNode(fileIdentifier, mdcSchemaLocation);
            var nceaClassifierInfoNode = CreateNceaClassifierInfoNode(mdcSchemaLocation);
            rootNode.Add(nceaIdentifiersNode);
            rootNode.Add(nceaClassifierInfoNode);
        }
        _logger.LogInformation("Mapping completed for DataSource: Medin, FileIdentifier: {fileIdentifier}", fileIdentifier);

        return await Task.FromResult(responseXml.ToString());
    }

    private static XElement CreateNceaClassifierInfoNode(string mdcSchemaLocationStr)
    {        
        XNamespace mdcSchemaLocation = mdcSchemaLocationStr;
        var nceaClassifierInfo = new XElement(mdcSchemaLocation + "nceaClassifierInfo");        
        var nc_Classifiers = new XElement(mdcSchemaLocation + "NC_Classifiers");
        nceaClassifierInfo.Add(nc_Classifiers);
        return nceaClassifierInfo;
    }

    private static XElement CreateNceaIdentifiersNode(string fileIdentifier, string mdcSchemaLocationStr)
    {        
        XNamespace mdcSchemaLocation = mdcSchemaLocationStr;
        var nceaIdentifiers = new XElement(mdcSchemaLocation + "nceaIdentifiers");
        var dataSource = Convert.ToString(ProcessorType.Medin);
        var nceaSourceSystemReferenceIDValue = fileIdentifier;
        var nceaCatalogueEntryValue = string.Concat(dataSource, "_", fileIdentifier);

        //Create MasterReferenceID node
        var nceaMasterReferenceID = new XElement(mdcSchemaLocation + "MasterReferenceID");
        var nceaCatalogueEntry = new XElement(mdcSchemaLocation + "catalogueEntry");
        var nceaSourceSystemReferenceID = new XElement(mdcSchemaLocation + "sourceSystemReferenceID");
        nceaSourceSystemReferenceID.Add(GetGcoCharacterString(nceaSourceSystemReferenceIDValue));
        nceaCatalogueEntry.Add(GetGcoCharacterString(nceaCatalogueEntryValue));
        nceaMasterReferenceID.Add(nceaCatalogueEntry);
        nceaMasterReferenceID.Add(nceaSourceSystemReferenceID);

        //Create nceaIdentifiers node
        nceaIdentifiers.Add(nceaMasterReferenceID);

        return nceaIdentifiers;
    }

    private static XElement GetGcoCharacterString (string value)
    {
        XNamespace gcoNamespace = "http://www.isotc211.org/2005/gco";
        return new XElement(gcoNamespace + "CharacterString", value);
    }

    private static string GetFileIdentifier(XElement xmlElement)
    {
        var gmdNameSpaceString = "http://www.isotc211.org/2005/gmd";
        var fileIdentifierXmlElement = xmlElement.Descendants()
                               .FirstOrDefault(n => n.Name.Namespace.NamespaceName == gmdNameSpaceString
                               && n.Name.LocalName == "fileIdentifier");
        var fileIdentifier = fileIdentifierXmlElement?.Descendants()?.FirstOrDefault()?.Value;
        return (fileIdentifier??string.Empty);
    }
}
