using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spring.Data.NHibernate.Generic.Support;

namespace SpringDemo.DAO
{
    public class BaseRepository<T> : HibernateDaoSupport, IRepository<T>
    {
        public object Save(T entity)
        {
            return this.HibernateTemplate.Save(entity);
        }

        public T Get(object id)
        {
            return this.HibernateTemplate.Get<T>(id);
        }

        public void Update(T entity)
        {
            this.HibernateTemplate.Update(entity);
        }

        public void Delete(T entity)
        {
            this.HibernateTemplate.Delete(entity);
        }
    }
}