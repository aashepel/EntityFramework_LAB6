using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IRepositoryAsync<T> where T : BaseEntity
    {
        public Task<T> GetByIdAsync(int id);
        public Task<ICollection<T>> GetAllAsync();
        public Task CreateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task DeleteAsyncById(int id);
        public Task UpdateAsync(T entity);
    }
}
