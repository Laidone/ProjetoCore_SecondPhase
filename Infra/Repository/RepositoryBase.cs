using Domain.Interfaces;
using Domain.Models;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : Entity, IAggregateRoot
    {
        protected readonly ProductContext _context;
        protected readonly DbSet<T> _dbSet;
        public RepositoryBase(ProductContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync();
        }
        public async Task<T> FindById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
        /*public async Task<List<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }*/
        public async Task Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public async Task Remove(T entity)
        {
            _dbSet.Remove(entity);
            await Task.CompletedTask;
        }
        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await Task.CompletedTask;
        }
    }
}
