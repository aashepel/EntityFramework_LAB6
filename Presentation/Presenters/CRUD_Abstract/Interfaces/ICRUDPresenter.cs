using Presentation.Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.CRUD.Interfaces
{
    public interface ICRUDPresenter : IPresenter
    {
        bool IsValidParams();
    }
}
