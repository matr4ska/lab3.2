using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace DataAccessLayer
{
    public class EntityRepository<T> : IRepository<T> 
        where T : class, IDomainObject, new()
    {
        public Context context;

        public EntityRepository()
        {
            context = new Context();
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetItem(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Create(T item)
        {
            context.Set<T>().Add(item);
        }   

        public void Update(T item)
        {
            context.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            context.Set<T>().Remove(GetItem(id));
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
