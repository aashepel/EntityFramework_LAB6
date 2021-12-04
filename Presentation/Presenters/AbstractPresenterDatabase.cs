using Core;
using DatabaseModels;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public abstract class AbstractPresenterDatabase<TView, T>
        where TView : IViewDatabase<T>
        where T : BaseEntity
    {
        private readonly TView _view;
        private readonly IRepositoryAsync<T> _repository;

        public AbstractPresenterDatabase(TView view, IRepositoryAsync<T> repository)
        {
            _repository = repository;
            _view = view;
        }

        public virtual void OnViewInitialized()
        {
        }

        public virtual void OnViewLoaded()
        {
        }
    }
}
