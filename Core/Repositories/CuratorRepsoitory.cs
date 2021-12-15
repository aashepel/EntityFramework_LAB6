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
    public class CuratorRepsoitory : RepositoryGeneric<Curator>, ICuratorRepository
    {
        public CuratorRepsoitory() : base()
        {
        }

        public override ICollection<Curator> GetAll()
        {
            return _context.Curators.Include(p => p.Group).ToList();
        }

        public override Curator GetById(int id)
        {
            return _context.Set<Curator>().FirstOrDefault(p => p.Id == id);
        }
    }
}
