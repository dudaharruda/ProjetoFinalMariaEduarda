﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaE.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Id da Cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Nome da Cidade")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }
    }
}
