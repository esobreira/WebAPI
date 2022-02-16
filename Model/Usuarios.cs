using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("USUARIOS", Schema = "SOBREIRA")]
    public class Usuarios
    {
        [Key]
        public int ID { get; set; }
        public string NOME { get; set; }
        public DateTime DT_NASCIMENTO { get; set; }
        public string CPF { get; set; }
    }
}
