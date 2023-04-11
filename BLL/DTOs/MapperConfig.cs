using AutoMapper;
using DAL.Models;

namespace BLL.DTOs
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Members, MemberDto>();
            CreateMap<MemberDto, Members>();
        }
    }
}