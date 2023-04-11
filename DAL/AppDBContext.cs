using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base("name=mssql_project")
        { }

        public  DbSet<Project> Projects { get; set; }
        public  DbSet<Members> Members { get; set; }
    }
}
