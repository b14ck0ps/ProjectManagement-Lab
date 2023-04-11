using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class ProjectRepository : Database, IRepository<Project, int, bool>
    {
        public bool Add(Project entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}
