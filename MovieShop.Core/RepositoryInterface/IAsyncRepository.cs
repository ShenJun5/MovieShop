using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MovieShop.Core.RepositoryInterface
{
    public interface IAsyncRepository<T> where T : class
    {
        // CRUD
        //Reading
        T GetByIdAsync(int id);
        IEnumerable<T> ListAllAsync();
        IEnumerable<T> ListAsync(Expression<Func<T, bool>> filter);
        int GetCountAsync(Expression<Func<T, bool>> filter = null);
        bool GetExistsAsync(Expression<Func<T, bool>> filter = null);

        // C Creating
        T AddAsync(T entity);
        // U Update
        T UpdateAsync(T entity);
        // D Delete
        T DeleteAsync(T entity);
    }
}
