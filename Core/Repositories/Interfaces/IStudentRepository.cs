using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Interfaces
{
    public interface IStudentRepository : IRepositoryAsync<Student>
    {
        public Task<string> GetCuratorNameOfStudent(int studentId);
    }
}
