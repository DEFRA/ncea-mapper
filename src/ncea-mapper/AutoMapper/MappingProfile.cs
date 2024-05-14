using AutoMapper;
using Ncea.Mapper.Models;

namespace ncea.mapper.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Gemini23MdMetadata, MdcMdMetadata>();
        }
    }
}
