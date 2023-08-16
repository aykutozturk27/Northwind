using Northwind.Core.Entities;
using System.Linq.Expressions;

namespace Northwind.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        #region Sync Functions
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
        #endregion

        #region Async Functions
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity); 
        #endregion
    }
}