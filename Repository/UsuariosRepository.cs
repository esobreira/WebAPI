using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class UsuariosRepository : Repository<Usuarios>, IUsuariosRepository, IDisposable
    {
        public UsuariosRepository(DbContext context) : base(context)
        {
        }

        public void Dispose()
        {
            this.Context.Dispose();
        }
    }

    public interface IUsuariosRepository : IRepository<Usuarios>
    {
    }
}
