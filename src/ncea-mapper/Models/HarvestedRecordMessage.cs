using Ncea.Mapper.Enums;
namespace Ncea.Mapper.Models;

public class HarvestedRecordMessage
{
    public string FileIdentifier { get; set; } = null!;
    public DataFormat DataFormat { get; set; }
    public DataStandard DataStandard { get; set; }
    public DataSource DataSource { get; set; }
}

