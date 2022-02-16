using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("PEDIDOS_ITENS", Schema = "SOBREIRA")]
    public class Pedidos_Itens
    {
        [Key]
        public int ID { get; set; }
        public int ID_PEDIDO { get; set; }
        public int ID_PRODUTO { get; set; }
        public int QTDE { get; set; }
        public decimal VLR_UNITARIO { get; set; }
    }
}
