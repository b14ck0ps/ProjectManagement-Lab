using System.Collections.Generic;
using System.Linq;
using DAL.Interface;
using DAL.Models;

namespace DAL.Repository
{
    internal class MemberRepository : Database, IRepository<Member, int, bool>
    {
        public bool Add(Member entity)
        {
            Context.Members.Add(entity);
            return Context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var member = Get(id);
            Context.Members.Remove(member);
            return Context.SaveChanges() > 0;
        }

        public Member Get(int id) => Context.Members.Find(id);

        public List<Member> GetAll() => Context.Members.ToList();

        public bool Update(Member entity)
        {
            var member = Get(entity.Id);
            if (member == null) return false;
            Context.Entry(member).CurrentValues.SetValues(entity);
            return Context.SaveChanges() > 0;
        }
    }
}