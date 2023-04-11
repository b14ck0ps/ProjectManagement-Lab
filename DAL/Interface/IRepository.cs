using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IRepository<T, in Tid, out TRet>
    {
        TRet Add(T entity);
        TRet Update(T entity);
        TRet Delete(Tid id);
        T Get(Tid id);
        List<T> GetAll();
    }
}
