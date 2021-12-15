using DatabaseModels;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views.Curators.Interfaces
{
    public interface ICreateCuratorView : ICreateView<Curator>
    {
        public int? GroupId { get; }
        public string NameEntity { get; }
        public string Email { get; }

        public void SetGroupComboBox(ICollection<Group> groups);
    }
}
