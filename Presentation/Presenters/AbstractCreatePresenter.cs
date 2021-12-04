using Core;
using DatabaseModels;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public abstract class AbstractCreatePresenter<T> : AbstractPresenter, ICreatePresenter<T> where T : BaseEntity
    {
        protected IRepositoryAsync<T> _repository;
        protected ICreateView<T> _view;
        protected T _entity;

        public AbstractCreatePresenter(IRepositoryAsync<T> reposiory, ICreateView<T> view)
        {
            _repository = reposiory;
            _view = view;
        }

        protected abstract bool IsValid();

        public virtual async Task OnCreateClickAsync()
        {
            try
            {
                if (IsValid())
                    await _repository.CreateAsync(_entity);
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
