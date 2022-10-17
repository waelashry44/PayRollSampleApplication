using System.Linq.Expressions;

namespace PayRollSampleApplication.Contracts
{
    public interface IRepository<T, TKey>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task Add(T entity);
        void Delete(TKey id);
        Task<bool> SaveChangesAsync();
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);
    }
}
