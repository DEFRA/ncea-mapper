using AutoMapper;
using ncea.mapper.Extensions;
using Ncea.Mapper.Constants;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;

namespace Ncea.Mapper.Processors;

public class JnccMapper : IMapperService
{
    private readonly ILogger<JnccMapper> _logger;
    private readonly IMapper _mapper;

    public JnccMapper(ILogger<JnccMapper> logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }
    public async Task<string> Transform(string mdcSchemaLocation, string harvestedData, CancellationToken cancellationToken = default)
    {
        //Deserialize from Gemini2.2 Metadata string to MDC metadata
        var gemini2_2_Metadata = harvestedData.Deserialize<Gemini22MdMetadata>();
        var mdc_Metadata = _mapper.Map<MdcMdMetadata>(gemini2_2_Metadata);

        //Populate MDC classifier fields
        var fileIdentifier = mdc_Metadata.FileIdentifier.CharacterString;
        mdc_Metadata.nceaIdentifiers = CreateNceaIdentifiersNode(fileIdentifier!);
        mdc_Metadata.nceaClassifierInfo = CreateNceaClassifierInfoNode();

        //Serialize MDC metadata object to XML string
        var mdcMetadataString = mdc_Metadata.Serialize();
        _logger.LogInformation("Mapping completed for DataSource: JNCC, FileIdentifier: {fileIdentifier}", fileIdentifier);

        return await Task.FromResult(mdcMetadataString!);
    }

    private static NceaClassifierInfo CreateNceaClassifierInfoNode()
    {
        return new NceaClassifierInfo() { NC_Classifiers = [] };
    }

    private static NceaIdentifiers CreateNceaIdentifiersNode(string fileIdentifier)
    {
        var dataSource = Convert.ToString(ProcessorType.Jncc);
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
}
