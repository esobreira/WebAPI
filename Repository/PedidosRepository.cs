using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class PedidosRepository : Repository<Model.Pedidos>, IPedidosRepository
    {
        public PedidosRepository(DbContext context) : base(context)
        {
        }
    }

    public interface IPedidosRepository : IRepository<Model.Pedidos>
    {

    }
}
