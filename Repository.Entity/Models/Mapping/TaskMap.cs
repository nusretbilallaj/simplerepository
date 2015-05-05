using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Entity.Models.Mapping
{
    public class TaskMap : EntityTypeConfiguration<TaskVm>
    {
        public TaskMap()
        {
            // Primary Key
            this.HasKey(t => t.TaskId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.BroadDescription)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Task");
            this.Property(t => t.TaskId).HasColumnName("TaskId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BroadDescription).HasColumnName("BroadDescription");
            this.Property(t => t.ApplicationId).HasColumnName("ApplicationId");
            this.Property(t => t.InsertedOn).HasColumnName("InsertedOn");
            this.Property(t => t.CompletedOn).HasColumnName("CompletedOn");
            this.Property(t => t.IsComplete).HasColumnName("IsComplete");

            // Relationships
            this.HasOptional(t => t.Application)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.ApplicationId);

        }
    }
}
