using System.Data.Entity;
using DAL.Models;

namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=mssql_project")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Members> Members { get; set; }
    }
}