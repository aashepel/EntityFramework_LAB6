using Core.Repositories.Interfaces;
using DatabaseContext;
using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public class CuratorRepsoitory : RepositoryGeneric<Curator>, ICuratorRepository
    {
        public CuratorRepsoitory(ApplicationDbContext context) : base(context)
        {
        }
    }
}
