using DatabaseModels;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Groups.Interfaces
{
    public interface IGroupView : IViewDatabase<Group>
    {
        void FillingTable(ICollection<Group> entites);
    }
}
