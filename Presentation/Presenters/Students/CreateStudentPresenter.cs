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

            view.AgeChange += OnAgeChanged;
            view.NameChange += OnNameChanged;
            view.GroupChange += (string nameGroup) =>  OnGroupChanged(nameGroup);
            view.SetComboBoxGroups(_groupRepository.GetAll());
        }

        public override bool IsValidParams()
        {
            return true;
        }

        public void OnAgeChanged(uint age)
        {
            _entity.Age = age;
        }

        public void OnNameChanged(string name)
        {
            _entity.Name = name;
        }

        public void OnGroupChanged(string nameGroup)
        {
            _nameGroup = nameGroup;
        }

        protected override void OnCreateClick()
        {
            _entity.GroupId = _groupRepository.GetByName(_nameGroup).Id;
            base.OnCreateClick();
        }

        protected override void ClearAllFields()
        {
            (_view as ICreateView<Student>).ClearAllFields();
        }
    }
}
