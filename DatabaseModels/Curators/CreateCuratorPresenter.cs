using Core;
using Core.Repositories;
using DatabaseModels;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Curators.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Curators
{
    public class CreateCuratorPresenter : AbstractCreatePresenter<Curator>, ICreatePresenter<Curator>
    {
        IRepository<Group> _groupRepository = new GroupRepository();
        public CreateCuratorPresenter(ICreateView<Curator> view, IRepository<Curator> repository) : base(view, repository)
        {
            (view as ICreateCuratorView).SetGroupComboBox(_groupRepository.GetAll());
        }

        protected override void GetEntityValueFromForm()
        {
            _entity.GroupId = (_view as ICreateCuratorView).GroupId;
            _entity.Name = (_view as ICreateCuratorView).Name;
            _entity.Email = (_view as ICreateCuratorView).Email;
        }
    }
}
