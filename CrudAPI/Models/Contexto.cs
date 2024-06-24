using Microsoft.EntityFrameworkCore;

namespace CrudAPI.Models{
    public partial class Contexto : DbContext{
        public Contexto(){}
        public DbSet<Pessoa> Pessoas {get; set;}
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes){
        }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
        optionsBuilder.UseSqlServer("ConexaoBD");
}
    }
    
}