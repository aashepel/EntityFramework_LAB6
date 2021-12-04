using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface IViewDatabase<T> : IView where T : BaseEntity
    {
        event Action CreateClick;
        event Action DeleteClick;
        event Action UpdateClick;
        event Action ReloadClick;
    }
}
