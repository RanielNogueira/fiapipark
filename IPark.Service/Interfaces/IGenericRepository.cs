using System.Collections.Generic;

namespace IPark.Service.Interfaces
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        void Delete(int id);
        T Get(int id);
        void Update(T t);
        T Insert(T t);
    }
}
