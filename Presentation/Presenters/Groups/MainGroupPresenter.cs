using Core;
using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseModels;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Interfaces;
using Presentation.Presenters.Groups.Interfaces;
using Presentation.Views.Groups;
using Presentation.Views.Groups.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Groups
{
    public class MainGroupPresenter : AbstractPresenterDatabase<Group>, IGroupPresenter
    {
        public MainGroupPresenter(IViewDatabase<Group> view, IRepository<Group> repository) : base(view, repository)
        {

        }

        public override void OnCreateClick()
        {
            ICreateGroupView createGuropView = new CreateGroupView();
            IGroupRepository groupRepository = new GroupRepository();
            CreateGroupPresenter createGroupPresenter = new CreateGroupPresenter(createGuropView, groupRepository);
            createGroupPresenter.Show();
        }

        public override void OnUpdateClick()
        {
            throw new NotImplementedException();
        }
    }
}
