using AutoMapper;
using Ncea.Mapper.Constants;

namespace Ncea.Mapper.Models
{
    public class MapperConfigurations
    {
        public ProcessorType ProcessorType { get; set; }
        public string Type { get; set; } = null!;
        public string DataSourceApiBase { get; set; } = null!;
        public string DataSourceApiUrl { get; set; } = null!;
    }
}

