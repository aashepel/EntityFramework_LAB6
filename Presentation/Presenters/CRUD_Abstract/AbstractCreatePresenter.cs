using Core;
using DatabaseModels;
using Presentation.Presenters.CRUD;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public abstract class AbstractCreatePresenter<T> : AbstractCRUDPresenter<T>, ICreatePresenter<T> where T : BaseEntity, new()
    {
        protected T _entity = new();

        public AbstractCreatePresenter(ICreateView<T> view, IRepository<T> repository) : base(view, repository)
        {
            view.CreateClick += OnCreateClick;
        }

        protected abstract void ClearAllFields();
        protected virtual void OnSucceedCreate(string message)
        {
            ShowInfoMessage(message);
            ClearAllFields();
        }

        protected virtual void OnCreateClick()
        {
            try
            {
                if (IsValidParams())
                {
                    _repository.Create(_entity);
                    OnSucceedCreate("Успешно добавлено");
                }
                else
                    ShowInfoMessage("Ошибка при заполнении");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }
    }
}
