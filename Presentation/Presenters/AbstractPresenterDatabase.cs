using Core;
using DatabaseModels;
using Presentation.Interfaces;
using Presentation.Presenters.Interfaces;
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
        private readonly IViewDatabase<T> _view;
        private readonly IRepositoryAsync<T> _repository;

        public AbstractPresenterDatabase(IViewDatabase<T> view, IRepositoryAsync<T> repository)
        {
            _repository = repository;
            _view = view;
        }

        public abstract void OnCreateClick();
        public abstract void OnDeleteClick();
        public abstract void OnReloadDataClick();
        public abstract void OnUpdateClick();
    }
}
