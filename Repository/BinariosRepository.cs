using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class BinariosRepository : Repository<Binarios>, IBinariosRepository
    {
        public BinariosRepository(DbContext context) : base(context)
        {
        }
    }

    public interface IBinariosRepository : IRepository<Binarios>
    {
    }
}
