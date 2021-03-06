using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> FindAllAsync();
        Task<IEnumerable<T>> FindByConditionAync(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync(); 
    }
}