using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Common.EnumsDTO;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserDTO,User>().ReverseMap();
            CreateMap<HMOEnumDTO,HMOEnum>().ReverseMap();
        }
    }
}
