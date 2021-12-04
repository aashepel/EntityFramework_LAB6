using Core.Repositories.Interfaces;
using DatabaseContext;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class StudentRepository : RepositoryGenericAsync<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<string> GetCuratorNameOfStudent(int studentId)
        {
            var student = await _context.Set<Student>().Include(p => p.Group).ThenInclude(p => p.Curator).FirstOrDefaultAsync();
            if (student == null) throw new ArgumentNullException(nameof(student));
            return student.Group.Curator.Name;
        }
    }
}
