using Microsoft.EntityFrameworkCore;
using ProjetoFinalMariaE.Models;

namespace ProjetoFinalMariaE.Models
{
    public class Contexto : DbContext
    {
    public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    public DbSet<ProjetoFinalMariaE.Models.Cidade>? Cidade { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.Cliente>? Cliente { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.Colaborador>? Colaborador { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.Estado>? Estado { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.LocalRealizacao>? LocalRealizacao { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.Procedimento>? Procedimento { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.ProcedimentoRealizado>? ProcedimentoRealizado { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.TipoColaborador>? TipoColaborador { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.Usuario>? Usuario { get; set; }
    public DbSet<ProjetoFinalMariaE.Models.TipoProcedimento>? TipoProcedimento { get; set; }
        //public DbSet<Aluno> Aluno {get; set;}
    }
}
