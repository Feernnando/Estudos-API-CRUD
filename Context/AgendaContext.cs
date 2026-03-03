
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entityes;

namespace ModuloAPI.context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }

        public DbSet<Contato> Contatos {get; set;}
    }
}
