using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Shared
{
    public interface ICreateView<T> : IView where T : BaseEntity
    {
        event Action CreateClick;
        void ClearAllFields();
    }
}
