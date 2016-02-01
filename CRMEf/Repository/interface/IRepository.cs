using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CRMEf.Repository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Eager loading
        /// </summary>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// Lazy loading
        /// </summary>
        /// <param name="where"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        void Add(params T[] items);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        void Update(params T[] items);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        void Delete(params T[] items);
    }
}
