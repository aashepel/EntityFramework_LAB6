using Core.Repositories.Interfaces;
using DatabaseModels;
using Presentation.Presenters.Interfaces;
using Presentation.Views.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters.Students
{
    public class CreateStudentPresenter : AbstractPresenter, ICreatePresenter<Student>
    {
        private readonly ICreateView<Student> _view;
        private readonly IStudentRepository _repository;

        private Student _student = new Student();

        public CreateStudentPresenter(ICreateView<Student> view, IStudentRepository repository)
        {
            _view = view;
            _repository = repository;
        }

        public async Task OnCreateClickAsync()
        {
            try
            {
                await _repository.CreateAsync(_student);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }

        }
    }
}
