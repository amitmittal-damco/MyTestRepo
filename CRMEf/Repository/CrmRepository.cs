using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;


namespace CRMEf.Repository
{
    public class CrmRepository<T> : IRepository<T> where T : class
    {
        public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new AutoCribCrmConncetion())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                list = dbQuery.AsNoTracking().ToList<T>();
            }
            return list;
        }

        public virtual IList<T> GetList(Func<T, bool> where,params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;

            using (var context = new AutoCribCrmConncetion())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                list = dbQuery.AsNoTracking().Where(where).ToList<T>();
            }
            return list;
        }

        public virtual T GetSingle(Func<T, bool> where,params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;
            using (var context = new AutoCribCrmConncetion())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include<T, object>(navigationProperty));

                item = dbQuery.AsNoTracking() //Don't track any changes for the selected item
                    .FirstOrDefault(where); //Apply where clause
            }
            return item;
        }


        public virtual void Add(params T[] items)
        {
            using (var context = new AutoCribCrmConncetion())
            {
                foreach (T item in items)
                {
                    ;context.Entry(item).State = EntityState.Added;
                }
                context.SaveChanges();
            }
            using (var context = new AutoCribCrmConncetion())
            {
                var dbQuery = context.Set<T>();
                foreach (var item in items)
                {
                    dbQuery.Add(item);
                }   
            }
        }

        public virtual void Update(params T[] items)
        {
            using (var context = new AutoCribCrmConncetion())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public virtual void Delete(params T[] items)
        {
            using (var context = new AutoCribCrmConncetion())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }
    }
}
