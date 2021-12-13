using Presentation.Presenters.Interfaces;
using Presentation.Shared;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public abstract class AbstractPresenter : IPresenter
    {
        protected readonly IView _view;

        public AbstractPresenter(IView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        protected virtual IView View => _view;

        public virtual void Close()
        {
            _view.Close();
        }

        public virtual void Show()
        {
            _view.Show();
        }

        public virtual void ShowErrorMessage(string message)
        {
            MessageShower.ShowMessageError(message);
        }

        public virtual void ShowErrorMessage(Exception exception)
        {
            MessageShower.ShowMessageError(exception.Message);
        }

        public virtual void ShowInfoMessage(string message)
        {
            MessageShower.ShowMessageInfo(message);
        }

        public virtual bool ShowDialogMessage(string message)
        {
            return MessageShower.ShowYesNoMessage(message);
        }
    }
}
