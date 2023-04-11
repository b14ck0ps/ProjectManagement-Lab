using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Service
{
    public static class MemberService
    {
        public static bool CreateMember(MemberDto memberDto)
        {
            var memberRepository = DataFactory.MemberRepository();
            var member = ConvertMemberDtoToMember(memberDto);
            return memberRepository.Add(member);
        }

        public static List<MemberDto> GetMembers()
        {
            var memberRepository = DataFactory.MemberRepository();
            return ConvertList(memberRepository.GetAll());
        }

        public static MemberDto GetMember(int id)
        {
            var memberRepository = DataFactory.MemberRepository();
            return ConvertMemberToMemberDto(memberRepository.Get(id));
        }

        public static bool DeleteMember(int id)
        {
            var memberRepository = DataFactory.MemberRepository();
            return memberRepository.Delete(id);
        }

        private static MemberDto ConvertMemberToMemberDto(Members members)
        {
            return new MemberDto()
            {
                Id = members.Id,
                Name = members.Name,
                ProjectId = members.ProjectId
            };
        }
        private static Members ConvertMemberDtoToMember(MemberDto members)
        {
            return new Members()
            {
                Id = members.Id,
                Name = members.Name,
                ProjectId = members.ProjectId
            };
        }
        private static List<MemberDto> ConvertList(List<Members> members)
        {
            var data = new List<MemberDto>();
            foreach (Members member in members)
            {
                data.Add(ConvertMemberToMemberDto(member));
            }
            return data;
        }
    }
}
