using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Interfaces
{
    interface ICreatePresenter<T> : IPresenter where T : BaseEntity
    {
        Task OnCreateClickAsync();
    }
}
