using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Presenters.CRUD;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Shared;
using Presentation.Views.Students.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Students
{
    public sealed class CreateStudentPresenter : AbstractCreatePresenter<Student>
    {
        private readonly IGroupRepository _groupRepository;
        private string _nameGroup = "";
        public CreateStudentPresenter(ICreateStudentView view, IStudentRepository repository, IGroupRepository groupRepository) 
            : base(view, repository)
        {
            _groupRepository = groupRepository;
            view.SetComboBoxGroups(_groupRepository.GetAll());
        }

        protected override void GetEntityValueFromForm()
        {
            _entity.Age = (_view as ICreateStudentView).Age;
            _entity.Name = (_view as ICreateStudentView).NameEntity;
            _entity.GroupId = (_view as ICreateStudentView).GroupId;
        }
    }
}
