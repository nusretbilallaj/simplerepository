using System.Data.Entity;
using Repository.Entity.Models.Mapping;

namespace Repository.Entity.Models
{
    public class OrganiserContext : DbContext
    {
        static OrganiserContext()
        {
            Database.SetInitializer<OrganiserContext>(null);
        }

        public OrganiserContext()
            : base("Name=OrganiserContext")
        {
        }

        public DbSet<ApplicationVm> Applications { get; set; }
        public DbSet<TaskVm> Tasks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ApplicationMap());
            modelBuilder.Configurations.Add(new TaskMap());
        }
    }
}