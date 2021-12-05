using DatabaseModels;
using Presentation.Presenters.CRUD.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Interfaces
{
    public interface IUpdatePresenter<T> : ICRUDPresenter where T : BaseEntity
    {
        void OnUpdateClick();
    }
}
