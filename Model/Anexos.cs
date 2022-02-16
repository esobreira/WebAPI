using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("ANEXOS", Schema = "SOBREIRA")]
    public class Anexos
    {
        [Key]
        public int ID { get; set; }
        public string NOME_ARQUIVO { get; set; }
        public string EXTENSAO { get; set; }
    }
}
