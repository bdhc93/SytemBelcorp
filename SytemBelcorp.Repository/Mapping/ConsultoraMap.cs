using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository.Mapping
{
    public class ConsultoraMap : EntityTypeConfiguration<Consultora>
    {
        public ConsultoraMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.IdTipoConsultora)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("Consultora");
            
            this.HasRequired(h => h.TipoConsultora)
                .WithMany(h => h.Consultoras)
                .HasForeignKey(p => p.IdTipoConsultora)
                .WillCascadeOnDelete(false);
        }
    }
}
