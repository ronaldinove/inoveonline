using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Atv3._1.Models
{
    public class BibliotecaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {                   
            optionsBuilder.UseMySql("Server=localhost;DataBase=inove;Uid=root;");
        }

        public DbSet<Contato> Contatos {get; set;}
    }
}
