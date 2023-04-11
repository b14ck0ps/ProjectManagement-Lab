using DAL.Interface;
using DAL.Models;
using DAL.Repository;

namespace DAL
{
    public static class DataFactory
    {
        public static IRepository<Members, int, bool> MemberRepository() => new MemberRepository();
    }
}