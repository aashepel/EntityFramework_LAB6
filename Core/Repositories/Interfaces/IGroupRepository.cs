using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Interfaces
{
    public interface IGroupRepository : IRepository<Group>
    {
        uint CountStudentsInGroup(int groupId);
        double AvgAgeStudents(int curatorId);
        Group GetByName(string name);
    }
}
