using AutoMapper;
using Ncea.Mapper.BusinessExceptions;
using Ncea.Mapper.Enums;
using Ncea.Mapper.Extensions;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Ncea.Mapper.Processors;

public class MedinMapper : IMapperService
{
    private readonly IMapper _mapper;

    public MedinMapper(IMapper mapper)
    {
        _mapper = mapper;
    }
    public async Task<string> Transform(string mdcSchemaLocation, string harvestedData, CancellationToken cancellationToken = default)
    {
        //Add Namespaces
        var nameSpaces = new XmlSerializerNamespaces();
        nameSpaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
        nameSpaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
        nameSpaces.Add("gmd", "http://www.isotc211.org/2005/gmd");
        nameSpaces.Add("mdc", mdcSchemaLocation);

        //Deserialize from Gemini2.3 Metadata string to MDC metadata
        var gemini2_3_Metadata = harvestedData.Deserialize<Gemini23MdMetadata>();
        var mdc_Metadata = _mapper.Map<MdcMdMetadata>(gemini2_3_Metadata);
        var fileIdentifier = mdc_Metadata.FileIdentifier.CharacterString;

        //Compare source and target data
        var mdcMetadataStr = mdc_Metadata.Serialize(nameSpaces);
        var IsSourceAndTargetEqual = IsEqual(harvestedData, mdcMetadataStr);
        if (!IsSourceAndTargetEqual)
        {
            var exceptionMessage = $"Mapper Exception | Potential data loss identified for DataSource : {DataSource.Medin}, FileIdentifier : {fileIdentifier}";
            throw new XmlSchemaValidationException(exceptionMessage);
        }

        //Populate MDC classifier fields
        mdc_Metadata.nceaIdentifiers = CreateNceaIdentifiersNode(fileIdentifier!);
        mdc_Metadata.nceaClassifierInfo = CreateNceaClassifierInfoNode();

        //Serialize MDC metadata object to XML string
        var mdcMetadataString = mdc_Metadata.Serialize(nameSpaces);        
        return await Task.FromResult(mdcMetadataString!);
    }
    private static bool IsEqual(string sourceXmlStr, string targetXmlStr)
    {
        var sourceXml = XDocument.Parse(sourceXmlStr);
        var targetXml = XDocument.Parse(targetXmlStr);

        var sourceTags = sourceXml.Descendants().Select(x => x.Name.LocalName);
        var targetTags = targetXml.Descendants().Select(x => x.Name.LocalName);

        return (sourceXml.Descendants().Count() == targetXml.Descendants().Count());
    }

    private static NceaIdentifiers CreateNceaIdentifiersNode(string fileIdentifier)
    {
        var dataSource = Convert.ToString(DataSource.Medin);
        var nceaRefValue = string.Concat(dataSource, "_", fileIdentifier);
        return new NceaIdentifiers()
        {
            MasterReferenceID = new NceaIdentifiersMasterReferenceId()
            {
                catalogueEntry = new NceaIdentifiersMasterReferenceIdCatalogueEntry()
                {
                    CharacterString = nceaRefValue
                },
                sourceSystemReferenceID = new NceaIdentifiersMasterReferenceIdSourceSystemReferenceId()
                {
                    CharacterString = nceaRefValue
                }
            }
        };
    }

    private static NceaClassifierInfo CreateNceaClassifierInfoNode()
    {
        return new NceaClassifierInfo() { NC_Classifiers = [] };
    }
}
