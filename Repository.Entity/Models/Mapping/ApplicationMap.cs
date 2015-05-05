using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Entity.Models.Mapping
{
    public class ApplicationMap : EntityTypeConfiguration<ApplicationVm>
    {
        public ApplicationMap()
        {
            // Primary Key
            this.HasKey(t => t.ApplicationId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Application");
            this.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
