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
        private readonly IGroupRepository _groupRepos = new GroupRepository();
        public MainStudentPresenter(IStudentView view, IStudentRepository repository) : base(view, repository)
        {
            
        }

        public override void OnCreateClick()
        {
            ICreateStudentView createStudentView = new CreateStudentView();
            IStudentRepository studentRepository= new StudentRepository();
            IGroupRepository groupRepository = new GroupRepository();
            CreateStudentPresenter createStudentPresenter = new CreateStudentPresenter(createStudentView, studentRepository, groupRepository);
            createStudentView.Show();
            base.OnCreateClick();
        }

        public override void OnLoadDataClick()
        {
            (_view as IStudentView).FillingTable(_repository.GetAll(), _groupRepos.GetAll());
        }
    }
}