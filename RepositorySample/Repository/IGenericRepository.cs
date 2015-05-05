using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositorySample.Repository
{
    public interface IGenericRepository<TEntity>:IDisposable
    {
        Task<TEntity> GetByIdAsync(int id);
        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        Task EditAsync(TEntity entity);
        Task InsertAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}