namespace DAL.Repository
{
    public abstract class Database
    {
        internal AppDBContext context = new AppDBContext();
    }
}
