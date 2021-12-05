using Core;
using DatabaseModels;
using Presentation.Presenters.CRUD.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.CRUD
{
    public abstract class AbstractCRUDPresenter<T> : AbstractPresenter, ICRUDPresenter where T : BaseEntity, new()
    {
        protected readonly IRepository<T> _repository;

        public AbstractCRUDPresenter(IView view, IRepository<T> repository) : base(view)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public abstract bool IsValidParams();
    }
}
