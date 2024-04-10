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

        if (rootNode != null)
        {
            XNamespace mdc = mdcSchemaLocation;
            var mdcNameSpaceAttribute = new XAttribute(XNamespace.Xmlns + "mdc", mdc.NamespaceName);
            rootNode!.Add(mdcNameSpaceAttribute);
            var nceaIdentifiersNode = CreateNceaIdentifiersNode(mdcSchemaLocation);
            var nceaClassifierInfoNode = CreateNceaClassifierInfoNode(mdcSchemaLocation);
            rootNode.Add(nceaIdentifiersNode);
            rootNode.Add(nceaClassifierInfoNode);
        }        

        _logger.LogInformation("Medin transformer");
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

    private static XElement CreateNceaIdentifiersNode(string mdcSchemaLocationStr)
    {        
        XNamespace mdcSchemaLocation = mdcSchemaLocationStr;
        var nceaIdentifiers = new XElement(mdcSchemaLocation + "nceaIdentifiers");

        //Create ProjectID node
        var nceaIdentifiersProjectID = new XElement(mdcSchemaLocation + "ProjectID");
        var nceaIdentifiersProjectIDprojectID = new XElement(mdcSchemaLocation + "projectID");
        nceaIdentifiersProjectIDprojectID.Add(GetGcoCharacterString("Medin"));
        nceaIdentifiersProjectID.Add(nceaIdentifiersProjectIDprojectID);

        //Create MasterReferenceID node
        var nceaMasterReferenceID = new XElement(mdcSchemaLocation + "MasterReferenceID");
        var nceaCatalogueEntry = new XElement(mdcSchemaLocation + "catalogueEntry");
        var nceaSourceSystemReferenceID = new XElement(mdcSchemaLocation + "sourceSystemReferenceID");
        nceaSourceSystemReferenceID.Add(GetGcoCharacterString("Medin"));
        nceaCatalogueEntry.Add(GetGcoCharacterString("Medin"));
        nceaMasterReferenceID.Add(nceaCatalogueEntry);
        nceaMasterReferenceID.Add(nceaSourceSystemReferenceID);

        //Create nceaIdentifiers node
        nceaIdentifiers.Add(nceaIdentifiersProjectID);
        nceaIdentifiers.Add(nceaMasterReferenceID);

        return nceaIdentifiers;
    }

    private static XElement GetGcoCharacterString (string value)
    {
        XNamespace gcoNamespace = "http://www.isotc211.org/2005/gco";
        return new XElement(gcoNamespace + "CharacterString", value);
    }
}
