using Core;
using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Interfaces;
using Presentation.Presenters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class MainStudentPresenter : AbstractPresenterDatabase<Student>, IStudentPresenter
    {
        public MainStudentPresenter(IStudentView view, IStudentRepository repository) : base(view, repository)
        {
        }

        public override void OnCreateClick()
        {
            
        }

        public override void OnDeleteClick()
        {
            throw new NotImplementedException();
        }

        public override void OnReloadDataClick()
        {
            throw new NotImplementedException();
        }

        public override void OnUpdateClick()
        {
            throw new NotImplementedException();
        }
    }
}