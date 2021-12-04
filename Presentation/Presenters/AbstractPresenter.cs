using Presentation.Presenters.Interfaces;
using Presentation.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public abstract class AbstractPresenter : IPresenter
    {
        public virtual void ShowErrorMessage(string message)
        {
            HandleError.ShowMessageError(message);
        }

        public virtual void ShowErrorMessage(Exception exception)
        {
            HandleError.ShowMessageError(exception.Message);
        }

        public virtual void ShowInfoMessage(string message)
        {
            HandleError.ShowMessageInfo(message);
        }
    }
}
