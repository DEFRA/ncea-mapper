using Ncea.Mapper.Processors.Contracts;
using System.Reflection.Emit;
using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using YamlDotNet.Core.Tokens;
using System.Xml.Schema;
using System.Xml;

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
        return await Task.FromResult(harvestedData);
    }

    private static XElement CreateNceaClassifierInfoNode(string mdcSchemaLocationStr)
    {
        XNamespace gcoNamespace = "http://www.isotc211.org/2005/gco";
        XNamespace mdcSchemaLocation = mdcSchemaLocationStr;
        var nceaClassifierInfo = new XElement(mdcSchemaLocation + "nceaClassifierInfo");

        //Create classifierType node
        var nc_Classifiers = new XElement(mdcSchemaLocation + "NC_Classifiers");
        var classifier = new XElement(mdcSchemaLocation + "classifier");
        var classifierType = new XElement(mdcSchemaLocation + "classifierType");
        var classifierTypeCharacterString = new XElement(gcoNamespace + "CharacterString");
        classifierType.Add(classifierTypeCharacterString);

        //Create classifierValue node
        var classifierValue = new XElement(mdcSchemaLocation + "classifierValue");
        var classifierValueCharacterString = new XElement(gcoNamespace + "CharacterString");
        classifierValue.Add(classifierValueCharacterString);

        //Create child nc_Classifiers node
        var nc_ClassifiersChild = new XElement(mdcSchemaLocation + "NC_Classifiers");

        classifier.Add(classifierType);
        classifier.Add(classifierValue);
        classifier.Add(nc_ClassifiersChild);
        nc_Classifiers.Add(classifier);
        nceaClassifierInfo.Add(nc_Classifiers);

        return nceaClassifierInfo;
    }

    private static XElement CreateNceaIdentifiersNode(string mdcSchemaLocationStr)
    {
        XNamespace gcoNamespace = "http://www.isotc211.org/2005/gco";
        XNamespace mdcSchemaLocation = mdcSchemaLocationStr;
        var nceaIdentifiers = new XElement(mdcSchemaLocation + "nceaIdentifiers");

        //Create ProjectID node
        var nceaIdentifiersProjectID = new XElement(mdcSchemaLocation + "ProjectID");
        var nceaIdentifiersProjectIDprojectID = new XElement(mdcSchemaLocation + "projectID");
        var gcoCharacterString = new XElement(gcoNamespace + "CharacterString");
        nceaIdentifiersProjectIDprojectID.Add(gcoCharacterString);
        nceaIdentifiersProjectID.Add(nceaIdentifiersProjectIDprojectID);

        //Create MasterReferenceID node
        var nceaMasterReferenceID = new XElement(mdcSchemaLocation + "MasterReferenceID");
        var nceaCatalogueEntry = new XElement(mdcSchemaLocation + "catalogueEntry");
        var nceaCatalogueEntrygCharacterString = new XElement(gcoNamespace + "CharacterString");
        var nceaSourceSystemReferenceID = new XElement(mdcSchemaLocation + "sourceSystemReferenceID");
        var nceaSourceSystemReferenceIDCharacterString = new XElement(gcoNamespace + "CharacterString");
        nceaSourceSystemReferenceID.Add(nceaSourceSystemReferenceIDCharacterString);
        nceaCatalogueEntry.Add(nceaCatalogueEntrygCharacterString);
        nceaMasterReferenceID.Add(nceaCatalogueEntry);
        nceaMasterReferenceID.Add(nceaSourceSystemReferenceID);

        //Create nceaIdentifiers node
        nceaIdentifiers.Add(nceaIdentifiersProjectID);
        nceaIdentifiers.Add(nceaMasterReferenceID);

        return nceaIdentifiers;
    }
}
