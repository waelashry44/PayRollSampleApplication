using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PayRollSampleApplication.Contracts;
using PayRollSampleApplication.Data;
using System;
using System.Linq.Expressions;

namespace PayRollSampleApplication.Repository
{
    public class Repository<T,TKey> : IRepository<T,TKey> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _entities.ToListAsync();

        public async Task Add(T entity) => await _entities.AddAsync(entity);

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate) =>
            await _entities.FirstOrDefaultAsync(predicate);
        public async Task<bool> SaveChangesAsync() =>
            await _context.SaveChangesAsync().ConfigureAwait(false) > 0;

        public void Delete(TKey id)
        {
            T obj = _entities.Find(id);
            _ = _entities.Remove(obj);
        }
       
    }
}
