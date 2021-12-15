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
    public class GroupRepository : RepositoryGeneric<Group>, IGroupRepository
    {
        public GroupRepository() : base()
        {
        }

        public override void Create(Group entity)
        {
            entity.CreationDate = DateTime.Now.ToShortDateString();
            base.Create(entity);
        }

        public uint CountStudentsInGroup(int groupId)
        {
            var students = _context.Set<Student>().Where(p => p.GroupId == groupId).ToList();
            if (students == null) throw new ArgumentNullException(nameof(students));
            return (uint)students.Count();
        }

        public double AvgAgeStudents(int curatorId)
        {
            var curator = _context.Set<Curator>().FirstOrDefault(p => p.Id == curatorId);
            if (curator == null) throw new ArgumentNullException(nameof(curator));
            var students = _context.Set<Student>().Where(p => p.GroupId == curator.GroupId).ToList();


            if (students.Count() == 0)
                return 0;
            else
            {
                int sum = Enumerable.Sum(students.Select(p => Convert.ToInt32(p.Age)));
                return sum / students.Count();
            }
        }

        public Group GetByName(string name)
        {
            return _context.Set<Group>().FirstOrDefault(p => p.Name == name);
        }
    }
}
