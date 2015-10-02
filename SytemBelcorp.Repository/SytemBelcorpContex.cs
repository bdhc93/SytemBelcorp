using System.Data.Entity;
using SytemBelcorp.Entities;
using SytemBelcorp.Repository.Mapping;

namespace SytemBelcorp.Repository
{
    public class SytemBelcorpContex : DbContext
    {
        public SytemBelcorpContex()
        {
            Database.SetInitializer<SytemBelcorpContex>(new DropCreateDatabaseAlways<SytemBelcorpContex>());
        }

        public DbSet<Campaña> Campañas { get; set; }
        public DbSet<Consultora> Consultoras { get; set; }
        public DbSet<Horario> Horarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<TipoActividad> TipoActividades { get; set; }
        public DbSet<TipoConsultora> TipoConsultoras { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Zona> Zonas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CampañaMap());
            modelBuilder.Configurations.Add(new ConsultoraMap());
            modelBuilder.Configurations.Add(new HorarioMap());
            modelBuilder.Configurations.Add(new PedidoMap());
            modelBuilder.Configurations.Add(new SeccionMap());
            modelBuilder.Configurations.Add(new TipoActividadMap());
            modelBuilder.Configurations.Add(new TipoConsultoraMap());
            modelBuilder.Configurations.Add(new VisitaMap());
            modelBuilder.Configurations.Add(new ZonaMap());
        }
    }
}
