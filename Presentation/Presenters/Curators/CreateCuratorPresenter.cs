using Core;
using DatabaseModels;
using Presentation.Presenters.Interfaces;
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
        public CreateCuratorPresenter(ICreateView<Curator> view, IRepository<Curator> repository) : base(view, repository)
        {
        }

        public override bool IsValidParams()
        {
            
        }

        protected override void ClearAllFields()
        {
            throw new NotImplementedException();
        }
    }
}
