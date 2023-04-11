namespace DAL.Repository
{
    internal abstract class Database
    {
        internal AppDbContext context = new AppDbContext();
    }
}
