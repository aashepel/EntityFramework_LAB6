using Core;
using DatabaseModels;
using Presentation.Presenters.CRUD;
using Presentation.Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Views.Shared;

namespace Presentation.Presenters
{
    public abstract class AbstractUpdatePresenter<T> : AbstractCRUDPresenter<T>, IUpdatePresenter<T> where T : BaseEntity, new()
    {
        protected T _entity = new();
        public AbstractUpdatePresenter(IUpdateView<T> view, IRepository<T> repository) : base(view, repository)
        {

        }

        public virtual void OnUpdateClick()
        {
            if (IsValidParams())
            {
                try
                {
                    _repository.Update(_entity);
                }
                catch(Exception ex)
                {
                    ShowErrorMessage(ex);
                }
            }
            else
            {
                ShowErrorMessage("Ошибка при заполнении");
            }
        }
    }
}
