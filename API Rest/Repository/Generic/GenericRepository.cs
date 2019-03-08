using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model.Base;
using WebApplication1.Model.Context;

namespace WebApplication1.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly PostgresContext _context;
        private DbSet<T> dataset;

        public GenericRepository(PostgresContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }

        public void Delete(long id)
        {
            try
            {
                T item = dataset.Find(id);

                if (item != null)
                {
                    dataset.Remove(item);
                    _context.SaveChanges();
                }

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long? id)
        {
            return dataset.Find(id) != null;
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.Find(id);
        }

        public T Insert(T item)
        {
            dataset.Add(item);
            _context.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            T itemUpdate = dataset.Find(item.id);
            _context.Entry(itemUpdate).CurrentValues.SetValues(item);
            return item;
        }
    }
}
