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
        public uint Age { get; }
        public string NameEntity { get; }
        public int? GroupId { get; }

        void SetComboBoxGroups(ICollection<Group> groups);
    }
}
