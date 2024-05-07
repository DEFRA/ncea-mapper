﻿using AutoMapper;
using Moq;
using ncea.mapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
