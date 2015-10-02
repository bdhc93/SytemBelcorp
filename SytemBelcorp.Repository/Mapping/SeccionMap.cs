using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository.Mapping
{
    public class SeccionMap : EntityTypeConfiguration<Seccion>
    {
        public SeccionMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.IdZona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("Seccion");

            this.HasRequired(h => h.Zona)
                .WithMany(h => h.Secciones)
                .HasForeignKey(p => p.IdZona)
                .WillCascadeOnDelete(false);
        }
    }
}
