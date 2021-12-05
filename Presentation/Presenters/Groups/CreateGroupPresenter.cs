using Core;
using DatabaseModels;
using Presentation.Views.Groups.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Groups
{
    public class CreateGroupPresenter : AbstractCreatePresenter<Group>
    {
        public CreateGroupPresenter(ICreateGroupView view, IRepository<Group> repository) : base(view, repository)
        {
            view.NameChange += OnNameChanged;
        }

        public override bool IsValidParams()
        {
            return true;
        }

        public void OnNameChanged(string name)
        {
            _entity.Name = name;
        }

        protected override void ClearAllFields()
        {
            (_view as ICreateView<Group>).ClearAllFields();
        }
    }
}
