using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository.Mapping
{
    public class ZonaMap : EntityTypeConfiguration<Zona>
    {
        public ZonaMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.IdConsultora)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            this.ToTable("Zona");

            this.HasRequired(h => h.Consultora)
                .WithMany(h => h.Zonas)
                .HasForeignKey(p => p.IdConsultora)
                .WillCascadeOnDelete(false);
        }
    }
}
