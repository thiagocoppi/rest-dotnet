using System.Collections.Generic;
using WebApplication1.Model.Base;

namespace WebApplication1.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> FindAll();
        T FindById(long id);
        T Update(T item);
        void Delete(long id);
        T Insert(T item);
        bool Exist(long? id);
    }
}
