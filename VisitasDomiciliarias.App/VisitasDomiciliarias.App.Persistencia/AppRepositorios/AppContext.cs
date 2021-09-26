using Microsoft.EntityFrameworkCore;
using VisitasDomiciliarias.App.Dominio;
namespace VisitasDomiciliarias.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Propietario> Propietarios {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<HistoriaClinica> Historias {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = VisitasDomiciliarias.Data");
            }
        }

    }
}