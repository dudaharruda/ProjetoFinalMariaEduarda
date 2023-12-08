using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaE.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Id do Usuario")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do usuario")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]    
        [Display(Name = "Email Usuario")]
        public string UsuarioEmail { get; set; } = string.Empty;

        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuario")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
