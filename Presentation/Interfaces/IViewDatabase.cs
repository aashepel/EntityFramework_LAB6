using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface IViewDatabase<T> : IView where T : BaseEntity
    {
        void LoadAllEntites();
        void LoadById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
