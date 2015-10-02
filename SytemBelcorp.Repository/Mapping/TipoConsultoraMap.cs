using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SytemBelcorp.Entities;

namespace SytemBelcorp.Repository.Mapping
{
    public class TipoConsultoraMap : EntityTypeConfiguration<TipoConsultora>
    {
        public TipoConsultoraMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.ToTable("TipoConsultora");
        }
    }
}
