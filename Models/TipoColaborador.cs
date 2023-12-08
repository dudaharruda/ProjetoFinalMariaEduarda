using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaE.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Id do Tipo Colaborador")]
        public int Id { get; set; }

        [Column("TipocolaboradorNome")]
        [Display(Name = "Nome do Tipo Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
