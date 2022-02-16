using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class AnexosRepository : Repository<Anexos>, IAnexosRepository
    {
        public AnexosRepository(DbContext context) : base(context)
        {
        }
    }

    public interface IAnexosRepository : IRepository<Anexos>
    {
    }
}
