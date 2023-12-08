using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaE.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Id do Local de Realizacao")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome do Local")]
        public string LocalNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Id da Cidade")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
