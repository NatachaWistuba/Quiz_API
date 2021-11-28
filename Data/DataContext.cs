
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //Entity Framework - Code First
        //Construtor só digitar : ctor
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco
        public DbSet<Jogador> Jogadores { get ; set; }
        public DbSet<Questao> Questoes  { get ; set; }
        public DbSet<Jogar>     Jogadas     { get; set; }
        public DbSet<Login>     Connected     { get; set; }
         public DbSet<Categoria>    Categorias     { get; set; }

    }
}