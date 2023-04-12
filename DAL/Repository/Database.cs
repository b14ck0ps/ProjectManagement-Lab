namespace DAL.Repository
{
    internal abstract class Database
    {
        internal AppDbContext Context { get; } = new AppDbContext();
    }
}