using Ncea.Mapper.Enums;
namespace Ncea.Mapper.Models;

public class MdcMappedRecordMessage
{
    public MdcMappedRecordMessage(string fileIdentifier, DataSource dataSource)
    {
        FileIdentifier = fileIdentifier;
        DataSource = dataSource;
    }

    public string FileIdentifier { get; set; }
    public DataSource DataSource { get; set; }
}

