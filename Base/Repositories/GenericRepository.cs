using Solus.Microservice.Base.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Solus.Microservice.Base.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        public Task<T> GetByIdAsync(int id) => Task.FromResult(new T());
        public Task<IEnumerable<T>> GetAllAsync() => Task.FromResult<IEnumerable<T>>(new List<T>());
        public Task AddAsync(T entity) => Task.CompletedTask;
        public Task UpdateAsync(T entity) => Task.CompletedTask;
        public Task DeleteAsync(int id) => Task.CompletedTask;
    }
}