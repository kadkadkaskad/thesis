using AutoMapper;
using FlagHunter.Api.Entities;
using FlagHunter.Api.Models;

namespace FlagHunter.Api.Profiles
{
    public class TestProfile : Profile
    {
        public TestProfile()
        {
            CreateMap<Test, StudentTestDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Test, StudentTestDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<Test, StudentTestDto>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<CreateTestDto, Test>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<CreateTestDto, Test>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

            CreateMap<Test, TestDto>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<Test, TestDto>()
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));
            CreateMap<Test, TestDto>()
                .ForMember(dest => dest.ImageId, opt => opt.MapFrom(src => src.ImageId));
            // CreateMap<Test, TestDto>()
            //     .ForMember(dest => dest.Solved, opt => opt.MapFrom(src => src.Solved));
            
        }
    }
}
