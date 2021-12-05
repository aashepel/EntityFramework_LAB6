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
    public abstract class RepositoryGeneric<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        public RepositoryGeneric(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(_context));
        }

        public ApplicationDbContext Context => _context;

        public virtual void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual void DeleteById(int id)
        {
            var entity = _context.Set<T>().First(p => p.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public virtual ICollection<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public virtual T GetById(int id)
        {
            return _context.Set<T>().FirstOrDefault(p => p.Id == id);
        }

        public virtual void Update(T entity)
        {
            var entityCheck = _context.Set<T>().FirstOrDefaultAsync(p => p.Id == entity.Id);
            if (entityCheck != null)
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException(nameof(entity));
            }
        }
    }
}
