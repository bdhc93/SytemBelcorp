using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository.Mapping
{
    public class HorarioMap : EntityTypeConfiguration<Horario>
    {
        public HorarioMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.IdCampaña)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(c => c.IdConsultora)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(c => c.IdTipoActividad)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.ToTable("Horario");

            this.HasRequired(h => h.Campaña)
                .WithMany(h => h.Horarios)
                .HasForeignKey(p => p.IdCampaña)
                .WillCascadeOnDelete(false);

            this.HasRequired(h => h.Consultora)
                .WithMany(h => h.Horarios)
                .HasForeignKey(p => p.IdConsultora)
                .WillCascadeOnDelete(false);

            this.HasRequired(h => h.TipoActividad)
                .WithMany(h => h.Horarios)
                .HasForeignKey(p => p.IdTipoActividad)
                .WillCascadeOnDelete(false);
        }
    }
}
