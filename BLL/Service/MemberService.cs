using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;
using AutoMapper;
using DAL.Interface;
using DAL.Repository;

namespace BLL.Service
{
    public static class MemberService
    {
        private static readonly IRepository<Members, int, bool> MemberRepository = DataFactory.MemberRepository();

        public static bool CreateMember(MemberDto memberDto) =>
            MemberRepository.Add(Mapper.Map(memberDto, new Members()));

        public static List<MemberDto> GetMembers() => Mapper.Map(MemberRepository.GetAll(), new List<MemberDto>());

        public static MemberDto GetMember(int id) => Mapper.Map(MemberRepository.Get(id), new MemberDto());

        public static bool DeleteMember(int id) => MemberRepository.Delete(id);
    }
}