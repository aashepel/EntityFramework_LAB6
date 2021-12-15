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
    public class StudentRepository : RepositoryGeneric<Student>, IStudentRepository
    {
        public StudentRepository() : base()
        {
        }

        public override ICollection<Student> GetAll()
        {
            var students = _context.Set<Student>().Include(p => p.Group).ToList();
            return students;
        }

        public string? GetCuratorNameOfStudent(int studentId)
        {
            var student = _context.Set<Student>().FirstOrDefault();
            if (student == null) throw new ArgumentNullException(nameof(student));
            var curator = _context.Set<Curator>().FirstOrDefault(p => p.GroupId == student.GroupId);
            if (curator == null)
                return null;
            else
                return curator.Name;
        }
    }
}
