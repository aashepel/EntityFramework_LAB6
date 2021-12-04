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
    public class GroupRepository : RepositoryGenericAsync<Group>, IGroupRepository
    {
        public GroupRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<uint> CountStudentsInGroup(int groupId)
        {
            var group = await _context.Set<Group>().Include(p => p.Students).FirstOrDefaultAsync(p => p.Id == groupId);
            if (group == null) throw new ArgumentNullException(nameof(group));
            return (uint)group.Students.Count();
        }

        public async Task<decimal> AvgAgeStudents(int curatorId)
        {
            var group = await _context.Set<Group>().Include(p => p.Students).FirstOrDefaultAsync(p => p.CuratorId == curatorId);
            if (group == null) throw new ArgumentNullException(nameof(group));
            return (decimal)Enumerable.Average(group.Students.Select(p => p.Age));
        }
    }
}
