using Ncea.Mapper.Enums;

namespace Ncea.Mapper.Models;

public class HarvestedRecord
{
    public string FileIdentifier { get; set; } = null!;
    public string FileFormat { get; set; } = null!;
    public string ContentStandard {  get; set; } = null!;
    public DataSourceName DataSource { get; set; }
}
