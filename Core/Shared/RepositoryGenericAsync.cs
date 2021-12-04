using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class RepositoryGenericAsync<T> : IRepositoryAsync<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        public RepositoryGenericAsync(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(_context));
        }
        public virtual async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsyncById(int id)
        {
            var entity = await _context.Set<T>().FirstAsync(p => p.Id == id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(p => p.Id == id);
        }

        public virtual async Task UpdateAsync(T entity)
        {
            var entityCheck = _context.Set<T>().FirstOrDefaultAsync(p => p.Id == entity.Id);
            if (entityCheck != null)
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }
    }
}
