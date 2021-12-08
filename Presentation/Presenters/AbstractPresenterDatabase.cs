using Core;
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
            view.UpdateClick += OnUpdateClick;
            view.LoadClick += OnLoadDataClick;
        }

        public virtual ICollection<T> LoadAllRecords()
        {
            return _repository.GetAll();
        }
        public abstract void OnCreateClick();
        public abstract void OnDeleteClick();
        public virtual void OnLoadDataClick()
        {
            (_view as IViewDatabase<T>).FillingTable(_repository.GetAll());
        }
        public abstract void OnUpdateClick();
    }
}
