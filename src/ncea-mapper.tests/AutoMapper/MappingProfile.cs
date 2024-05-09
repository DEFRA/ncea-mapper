using AutoMapper;
using Ncea.Mapper.Models;

namespace ncea_mapper.tests.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Gemini23MdMetadata, MdcMdMetadata>();
        }
    }
}
