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
            Context.Members.Add(entity);
            return Context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var member = Get(id);
            Context.Members.Remove(member);
            return Context.SaveChanges() > 0;
        }

        public Members Get(int id) => Context.Members.Find(id);

        public List<Members> GetAll() => Context.Members.ToList();

        public bool Update(Members entity)
        {
            var member = Get(entity.Id);
            if (member == null) return false;
            Context.Entry(member).CurrentValues.SetValues(entity);
            return Context.SaveChanges() > 0;
        }
    }
}