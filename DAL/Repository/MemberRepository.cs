using DAL.Interface;
using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository
{
    public class MemberRepository : Database, IRepository<Members, int, bool>
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

        public Members Get(int id)
        {
            return context.Members.Find(id);
        }

        public List<Members> GetAll()
        {
            return context.Members.ToList();
        }

        public bool Update(Members entity)
        {
            var member = Get(entity.Id);
            if (member != null)
            {
                context.Entry(member).CurrentValues.SetValues(entity);
                return context.SaveChanges() > 0;
            }
            return false;
        }
    }
}
