using Core;
using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Students
{
    public class UpdateStudentPresenter : AbstractUpdatePresenter<Student>
    {
        public UpdateStudentPresenter(IUpdateView<Student> view, IStudentRepository repository) 
            : base(view, repository)
        {
        }

        public override bool IsValidParams()
        {
            throw new NotImplementedException();
        }
    }
}
