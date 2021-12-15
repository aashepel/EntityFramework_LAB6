using Core;
using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseContext;
using DatabaseModels;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Interfaces;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public abstract class AbstractPresenterDatabase<T> : AbstractPresenter, IDatabasePresenter<T>
        where T : BaseEntity
    {
        protected readonly IRepository<T> _repository;

        public AbstractPresenterDatabase(IViewDatabase<T> view, IRepository<T> repository) : base(view)
        {
            _repository = repository;

            view.CreateClick += OnCreateClick;
            view.DeleteClick += OnDeleteClick;
            view.LoadClick += OnLoadDataClick;
            view.SaveClick += OnSaveClick;
        }
        public virtual void OnCreateClick()
        {
            OnLoadDataClick();
        }

        public virtual void OnDeleteClick()
        {
            var IDs = (_view as IViewDatabase<T>).SelectedRowID();
            foreach (var id in IDs)
            {
                _repository.DeleteById(id);
            }

            OnLoadDataClick();
        }
        public abstract void OnLoadDataClick();

        public void OnSaveClick()
        {
            _repository.Save();
        }
    }
}
