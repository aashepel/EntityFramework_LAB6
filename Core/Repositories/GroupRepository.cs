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

        public decimal AvgAgeStudents(int curatorId)
        {
            var curator = _context.Set<Curator>().FirstOrDefault(p => p.Id == curatorId);
            if (curator == null) throw new ArgumentNullException(nameof(curator));
            var students = _context.Set<Student>().Where(p => p.GroupId == curator.GroupId).ToList();
            return (decimal)Enumerable.Average((IEnumerable<int>)students.Select(p => p.Age));
        }

        public Group GetByName(string name)
        {
            return _context.Set<Group>().FirstOrDefault(p => p.Name == name);
        }
    }
}
