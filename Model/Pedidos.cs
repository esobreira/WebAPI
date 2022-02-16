using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("PEDIDOS", Schema = "SOBREIRA")]
    public class Pedidos
    {
        [Key]
        public int ID { get; set; }
        public int ID_USUARIO { get; set; }
        public DateTime DT_INCLUSAO { get; set; }
    }
}
