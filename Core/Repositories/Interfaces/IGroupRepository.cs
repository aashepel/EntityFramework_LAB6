using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Interfaces
{
    public interface IGroupRepository : IRepositoryAsync<Group>
    {
        Task<uint> CountStudentsInGroup(int groupId);
        Task<decimal> AvgAgeStudents(int curatorId);
    }
}
