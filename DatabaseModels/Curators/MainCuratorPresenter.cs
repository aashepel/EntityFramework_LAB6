using Core;
using Core.Repositories;
using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Interfaces;
using Presentation.Presenters.Curators.Interfaces;
using Presentation.Presenters.Groups;
using Presentation.Views.Curators;
using Presentation.Views.Curators.Interfaces;
using Presentation.Views.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Curators
{
    public class MainCuratorPresenter : AbstractPresenterDatabase<Curator>, ICuratorPresenter
    {
        public MainCuratorPresenter(IViewDatabase<Curator> view, IRepository<Curator> repository) : base(view, repository)
        {
        }

        public override void OnCreateClick()
        {
            ICreateCuratorView createCuratorView = new CreateCuratorView();
            ICuratorRepository groupRepository = new CuratorRepsoitory();
            CreateCuratorPresenter createCuratorPresenter = new CreateCuratorPresenter(createCuratorView, groupRepository);
            createCuratorView.Show();
            base.OnCreateClick();
        }

        public override void OnUpdateClick()
        {
            throw new NotImplementedException();
        }
    }
}
