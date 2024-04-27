using Microsoft.EntityFrameworkCore;
using MyFirstAPI.models;

namespace MyFirstAPI.Context
{
    public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
    {

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}           