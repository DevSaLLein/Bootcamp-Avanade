using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using MyFirstAPI.Context.Map;
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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}          