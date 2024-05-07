using AutoMapper;
using ncea.mapper.Extensions;
using ncea.mapper.Models;
using Ncea.Mapper.Constants;
using Ncea.Mapper.Processors.Contracts;
using System.Xml.Linq;

namespace Ncea.Mapper.Processors;

public class MedinMapper : IMapperService
{    
    private readonly ILogger<MedinMapper> _logger;
    private readonly IMapper _mapper;

    public MedinMapper(ILogger<MedinMapper> logger, IMapper mapper)
    {     
        _logger = logger;
        _mapper = mapper;
    }
    public async Task<string> Transform(string mdcSchemaLocation, string harvestedData, CancellationToken cancellationToken = default)
    {
        //Deserialize from Gemini2.3 Metadata string to MDC metadata
        var gemini2_3_Metadata = harvestedData.Deserialize<Gemini23MdMetadata>();
        var mdc_Metadata = _mapper.Map<MdcMdMetadata>(gemini2_3_Metadata);

        //Populate MDC classifier fields
        var fileIdentifier = mdc_Metadata.FileIdentifier.CharacterString;
        mdc_Metadata.nceaIdentifiers = CreateNceaIdentifiersNode(fileIdentifier!);
        mdc_Metadata.nceaClassifierInfo = CreateNceaClassifierInfoNode();

        //Serialize MDC metadata object to XML string
        var mdcMetadataString = mdc_Metadata.Serialize();
        _logger.LogInformation("Mapping completed for DataSource: Medin, FileIdentifier: {fileIdentifier}", fileIdentifier);
        
        return await Task.FromResult(mdcMetadataString!);
    }

    private static NceaClassifierInfo CreateNceaClassifierInfoNode()
    {       
        return new NceaClassifierInfo() { NC_Classifiers = [] };
    }

    private static NceaIdentifiers CreateNceaIdentifiersNode(string fileIdentifier)
    {
        var dataSource = Convert.ToString(ProcessorType.Medin);
        var nceaRefValue = string.Concat(dataSource, "_", fileIdentifier);
        return new NceaIdentifiers()
                    {
                        MasterReferenceID = new NceaIdentifiersMasterReferenceID()
                        {
                            catalogueEntry = new NceaIdentifiersMasterReferenceIDCatalogueEntry() 
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
}
