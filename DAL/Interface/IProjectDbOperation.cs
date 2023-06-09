using System;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IProjectDbOperation : IRepository<Project, int, bool>
    {
        List<Project> GetByStatus(string status);
        List<Project> GetByStatusAndStartDate(string status, DateTime startDate);
    }
}