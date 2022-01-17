using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : IAggregateRoot
    {
        Task<IEnumerable<T>> Find(Expression <Func<T, bool>> expression);
        Task<T> FindById(Guid id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Remove(T entity);
        Task<int> SaveChanges();
        Task<IEnumerable<T>> GetAll();

    }
}
