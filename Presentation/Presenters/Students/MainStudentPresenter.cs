using Core;
using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Interfaces;
using Presentation.Presenters.Interfaces;
using Presentation.Presenters.Students;
using Presentation.Views.Students;
using Presentation.Views.Students.Interfaces;
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
            ICreateStudentView createStudentView = new CreateStudentView();
            CreateStudentPresenter createStudentPresenter = new CreateStudentPresenter(createStudentView, AppServices.Instance.ServiceProvider.GetService<IStudentRepository>(), AppServices.Instance.ServiceProvider.GetService<IGroupRepository>());
            createStudentView.Show();
        }

        public override void OnDeleteClick()
        {
            throw new NotImplementedException();
        }

        public override void OnLoadDataClick()
        {
            (_view as IStudentView).FillingTable(_repository.GetAll());
        }

        public override void OnUpdateClick()
        {
            
        }
    }
}