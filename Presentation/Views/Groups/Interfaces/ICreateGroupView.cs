using DatabaseModels;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Groups.Interfaces
{
    public interface ICreateGroupView : ICreateView<Group>
    {
        event Action<string> NameChange;
    }
}
