﻿using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interface;
using DAL.Models;

namespace DAL.Repository
{
    internal class ProjectRepository : Database, IProjectDbOperation
    {
        public bool Add(Project entity)
        {
            Context.Projects.Add(entity);
            return Context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var project = Get(id);
            Context.Projects.Remove(project);
            return Context.SaveChanges() > 0;
        }

        public Project Get(int id) => Context.Projects.Find(id);

        public List<Project> GetAll() => Context.Projects.ToList();

        public bool Update(Project entity)
        {
            var project = Get(entity.Id);
            if (project == null) return false;
            Context.Entry(project).CurrentValues.SetValues(entity);
            return Context.SaveChanges() > 0;
        }

        public List<Project> GetByStatus(string status) => Context.Projects.Where(x => x.Status == status).ToList();

        public List<Project> GetByStatusAndStartDate(string status, DateTime startDate) =>
            Context.Projects.Where(x => x.Status == status && x.StartDate == startDate).ToList();
    }
}