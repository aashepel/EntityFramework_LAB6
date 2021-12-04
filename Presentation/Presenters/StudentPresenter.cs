using Core;
using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class StudentPresenter : AbstractPresenterDatabase<IStudentView, Student>
    {
        public StudentPresenter(IStudentView view, IStudentRepository repository) : base(view, repository)
        {
        }
    }
}
