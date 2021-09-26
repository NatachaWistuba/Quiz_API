using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //Construtor só digitar : ctor
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }

        //Lista de propriedades que vão virar tabelas no banco
        public DbSet<Jogador> Jogadores { get ; set; }
        public DbSet<Questao> Questoes  { get ; set; }


    }
}