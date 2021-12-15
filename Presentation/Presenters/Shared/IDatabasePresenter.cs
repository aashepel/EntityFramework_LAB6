using DatabaseModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Presenters.Interfaces
{
    public interface IDatabasePresenter<T> : IPresenter where T : BaseEntity
    {
        void OnCreateClick();
        void OnSaveClick();
        void OnDeleteClick();
        void OnLoadDataClick();
    }
}
