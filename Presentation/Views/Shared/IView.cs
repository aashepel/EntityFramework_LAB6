using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Shared
{
    public interface IView
    {
        void ShowErrorMessage(string message);
        void ShowInfoMessage(string message);
        void ShowSuccessMessage(string message);
        void ShowWarningMessage(string message);
    }
}
