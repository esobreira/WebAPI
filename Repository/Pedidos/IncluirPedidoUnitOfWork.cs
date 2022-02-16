using Api.Repository.Patterns;
using Model;
using Model.Dto.Pedidos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository.Pedidos
{
    public class IncluirPedidoUnitOfWork : UnitOfWork
    {
        public IPedidosRepository Pedidos { get; private set; }

        public IPedidosItensRepository Pedidos_Itens { get; private set; }

        public IncluirPedidoUnitOfWork(DbContext context) : base(context)
        {
            Pedidos = new PedidosRepository(context);
            Pedidos_Itens = new PedidosItensRepository(context);
        }

        public Model.Pedidos IncluirPedido(IncluirPedidoDto pedido)
        {
            try
            {
                BeginTransaction();

                var usuariosRepository = new UsuariosRepository(DataContext);
                usuariosRepository.Get(pedido.Id_Usuario);

                var pd = new Model.Pedidos()
                {
                    ID_USUARIO = pedido.Id_Usuario,
                    DT_INCLUSAO = DateTime.Now
                };
                Pedidos.Add(pd);
                Pedidos.Save();

                foreach (var item in pedido.Itens)
                {
                    var itemped = new Pedidos_Itens()
                    {
                        ID_PEDIDO = pd.ID,
                        ID_PRODUTO = item.Id_Produto,
                        QTDE = item.Qtde,
                        VLR_UNITARIO = item.Valor_Unitario
                    };
                    Pedidos_Itens.Add(itemped);
                    Pedidos_Itens.Save();
                }

                Commit();

                return pd;
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
        }


    }
}
