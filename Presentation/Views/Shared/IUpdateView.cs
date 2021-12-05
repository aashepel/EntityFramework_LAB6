using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Shared
{
    public interface IUpdateView<T> : IView where T : BaseEntity
    {
        event Action UpdateClick;
    }
}
