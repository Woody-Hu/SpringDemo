using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringDemo.DAO
{
    public interface IRepository<T>
    {
        void Delete(T entity);
        T Get(object id);
        object Save(T entity);
        void Update(T entity);
    }
}
