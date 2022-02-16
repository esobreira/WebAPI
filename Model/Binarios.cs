using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("BINARIOS", Schema = "SOBREIRA")]
    public class Binarios
    {
        [Key]
        public int ID { get; set; }
        public string BASE64STRING { get; set; }
        public DateTime DT_INCLUSAO { get; set; }
        public int ID_ANEXO { get; set; }
    }
}
