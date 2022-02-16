using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class PedidosItensRepository : Repository<Model.Pedidos_Itens>, IPedidosItensRepository
    {
        public PedidosItensRepository(DbContext context) : base(context)
        {
        }
    }
    public interface IPedidosItensRepository : IRepository<Model.Pedidos_Itens>
    {
    }
}
