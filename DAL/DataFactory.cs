﻿using DAL.Interface;
using DAL.Models;
using DAL.Repository;

namespace DAL
{
    public static class DataFactory
    {
        public static IRepository<Member, int, bool> MemberRepository() => new MemberRepository();
        public static IProjectDbOperation ProjectRepository() => new ProjectRepository();
    }
}