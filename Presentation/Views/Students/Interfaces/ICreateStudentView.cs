using DatabaseModels;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Students.Interfaces
{
    public interface ICreateStudentView : ICreateView<Student>
    {
        event Action<uint> AgeChange;
        event Action<string> NameChange;
        event Action<string> GroupChange;

        void SetComboBoxGroups(ICollection<Group> groups);
    }
}
