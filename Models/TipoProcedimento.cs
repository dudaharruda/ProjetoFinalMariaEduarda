using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaE.Models
{
    [Table("TipoPrecedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Id do Procedimento")]
        public int Id { get; set; }

        [Column("TipoPrecedimentoNome")]
        [Display(Name = "Nome do Tipo Procedimento")]
        public string TipoPrecedimentoNome { get; set; } = string.Empty;
    }
}
