using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("PRODUTOS", Schema = "SOBREIRA")]
    public class Produtos
    {
        [Key]
        public int ID { get; set; }
        public string NOME { get; set; }
        public DateTime DT_INCLUSAO { get; set; }
        public int ID_FOTO { get; set; }
    }
}
