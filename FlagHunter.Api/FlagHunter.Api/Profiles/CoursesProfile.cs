using AutoMapper;
using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlagHunter.Api.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<Course, CourseDto>()
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.CourseId));
        }
    }
}
