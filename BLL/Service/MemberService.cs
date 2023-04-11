using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;
using AutoMapper;
using DAL.Repository;

namespace BLL.Service
{
    public static class MemberService
    {
        public static bool CreateMember(MemberDto memberDto)
        {
            var memberRepository = DataFactory.MemberRepository();
            var member = Mapper.Map(memberDto, new Members());
            return memberRepository.Add(member);
        }

        public static List<MemberDto> GetMembers()
        {
            var memberRepository = DataFactory.MemberRepository();
            return Mapper.Map(memberRepository.GetAll(), new List<MemberDto>());
        }

        public static MemberDto GetMember(int id)
        {
            var memberRepository = DataFactory.MemberRepository();
            return Mapper.Map(memberRepository.Get(id), new MemberDto());
        }

        public static bool DeleteMember(int id)
        {
            var memberRepository = DataFactory.MemberRepository();
            return memberRepository.Delete(id);
        }
    }
}