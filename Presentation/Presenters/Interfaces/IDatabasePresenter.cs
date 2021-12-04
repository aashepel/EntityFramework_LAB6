using DatabaseModels;

namespace Presentation.Presenters.Interfaces
{
    interface IDatabasePresenter<T> where T : BaseEntity
    {
        void OnCreateClick();
        void OnUpdateClick();
        void OnDeleteClick();
        void OnReloadDataClick();
    }
}
