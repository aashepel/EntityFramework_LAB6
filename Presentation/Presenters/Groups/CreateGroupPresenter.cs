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

        }

        protected override void GetEntityValueFromForm()
        {
            _entity.Name = (_view as ICreateGroupView).NameEntity;
        }
    }
}
