using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto.Pedidos
{
    public class IncluirPedidoDto
    {
        public int Id_Usuario { get; set; }

        public List<ItensPedido> Itens { get; set; }

        public class ItensPedido
        {
            public int Id_Produto { get; set; }
            public int Qtde { get; set; }
            public decimal Valor_Unitario { get; set; }
        }
    }
}
