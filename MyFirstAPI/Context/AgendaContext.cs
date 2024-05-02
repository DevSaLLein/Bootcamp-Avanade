using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MyFirstAPI.models;


namespace MyFirstAPI.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress; Initial Catalog=Agenda; Integrated Security=True; TrustServerCertificate=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

            // optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}          