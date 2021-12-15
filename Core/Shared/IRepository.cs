using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IRepository<T> where T : BaseEntity
    {
        public T GetById(int id);
        public ICollection<T> GetAll();
        public void Create(T entity);
        public void Delete(T entity);
        public void DeleteById(int id);
        public void Update(T entity);
        public void Save();
    }
}
