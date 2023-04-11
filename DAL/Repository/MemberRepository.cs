using System.Collections.Generic;
using System.Linq;
using DAL.Interface;
using DAL.Models;

namespace DAL.Repository
{
    internal class MemberRepository : Database, IRepository<Members, int, bool>
    {
        public bool Add(Members entity)
        {
            context.Members.Add(entity);
            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var member = Get(id);
            context.Members.Remove(member);
            return context.SaveChanges() > 0;
        }

        public Members Get(int id) => context.Members.Find(id);

        public List<Members> GetAll() => context.Members.ToList();

        public bool Update(Members entity)
        {
            var member = Get(entity.Id);
            if (member == null) return false;
            context.Entry(member).CurrentValues.SetValues(entity);
            return context.SaveChanges() > 0;
        }
    }
}