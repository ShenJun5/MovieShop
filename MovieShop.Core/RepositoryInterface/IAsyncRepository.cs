using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Core.RepositoryInterface
{
    public interface IAsyncRepository<T> where T : class
    {
        // CRUD
        //Reading
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<IEnumerable<T>> ListAsync(Expression<Func<T, bool>> filter);
        Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null);
        Task<bool> GetExistingAsync(Expression<Func<T, bool>> filter = null);

        // C Creating
        Task<T> AddAsync(T entity);
        // U Update
        Task<T> UpdateAsync(T entity);
        // D Delete
        Task<T> DeleteAsync(T entity);
    }
}
