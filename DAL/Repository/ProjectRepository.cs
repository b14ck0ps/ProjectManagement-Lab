using System;
using System.Collections.Generic;
using DAL.Interface;
using DAL.Models;

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
