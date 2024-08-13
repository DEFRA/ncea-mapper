using Ncea.Mapper.Enums;
namespace Ncea.Mapper.Models;

public class MdcMappedRecordMessage
{
    public MdcMappedRecordMessage(string fileIdentifier, DataSource dataSource, MessageType messageType)
    {
        FileIdentifier = fileIdentifier;
        DataSource = dataSource;
        MessageType = messageType;
    }

    public string FileIdentifier { get; set; }
    public DataSource DataSource { get; set; }
    public MessageType MessageType { get; set; }
}

