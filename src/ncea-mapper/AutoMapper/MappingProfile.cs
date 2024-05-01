using AutoMapper;
using ncea.mapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncea.mapper.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Gemini2_3_MD_Metadata, Mdc_MD_Metadata>();
        }
    }
}
