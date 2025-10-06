using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DapperRepository<T> : IRepository<T>
        where T : class, IDomainObject, new()
    {
        public Context context;

        public DapperRepository()
        {
            context = new Context();
        }

        public IEnumerable<T> GetAll()
        {
            return new List<T>();
        }

        public T GetItem(int id)
        {
            return new T();
        }

        public void Create(T item)
        {

        }

        public void Update(T item)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
