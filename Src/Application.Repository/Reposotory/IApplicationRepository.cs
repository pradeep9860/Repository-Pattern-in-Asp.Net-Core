using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions; 

namespace Application
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> AsQueryable();
        IQueryable<T> AsQueryable(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
