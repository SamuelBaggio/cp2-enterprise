using cp2_enterprise.Models;
using Microsoft.EntityFrameworkCore;

namespace cp2_enterprise.Persistence
{
    public class OracleContext: DbContext
    {

        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AutoEscola> AutoEscolas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }


        public OracleContext(DbContextOptions<OracleContext> options) : base(options)
        {

        }

    }
}
