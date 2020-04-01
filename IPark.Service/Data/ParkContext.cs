using IPark.Domain;
using Microsoft.EntityFrameworkCore;

namespace IPark.Service.Data
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteLocatario> ClienteLocatario { get; set; }
        public DbSet<Locatario> Locatario { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
    }
}
