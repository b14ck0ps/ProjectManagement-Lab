using AutoMapper;
using DAL.Models;

namespace BLL.DTOs
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Member, MemberDto>();
            CreateMap<MemberDto, Member>();

            CreateMap<Project, ProjectDto>();
            CreateMap<ProjectDto, Project>();
        }
    }
}