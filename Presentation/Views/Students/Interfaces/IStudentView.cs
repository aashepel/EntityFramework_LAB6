using DatabaseModels;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Students.Interfaces
{
    public interface IStudentView : IViewDatabase<Student>
    {
        void FillingTable(ICollection<Student> students, ICollection<Group> groups);
    }
}
