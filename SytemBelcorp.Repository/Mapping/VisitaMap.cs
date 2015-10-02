using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository.Mapping
{
    public class VisitaMap : EntityTypeConfiguration<Visita>
    {
        public VisitaMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.IdHorario)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(c => c.IdPedido)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            this.ToTable("Visita");

            this.HasRequired(h => h.Horario)
                .WithMany(h => h.Visitas)
                .HasForeignKey(p => p.IdHorario)
                .WillCascadeOnDelete(false);

            this.HasRequired(h => h.Pedido)
                .WithMany(h => h.Visitas)
                .HasForeignKey(p => p.IdPedido)
                .WillCascadeOnDelete(false);
        }
    }
}
