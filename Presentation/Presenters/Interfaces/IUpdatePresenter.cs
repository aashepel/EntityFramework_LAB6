using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Interfaces
{
    public interface IUpdatePresenter<T> : IPresenter where T : BaseEntity
    {
    }
}
