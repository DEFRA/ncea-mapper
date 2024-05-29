using AutoMapper;
using Ncea.Mapper.Models;

namespace Ncea.Mapper.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Gemini23MdMetadata, MdcMdMetadata>();
        }
    }
}
