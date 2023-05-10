using Microsoft.EntityFrameworkCore;
using Models.Model;

namespace Models
{
    public class HostelContext : DbContext
    {
        public string CONNECTION_STRING { get { return "Host=localhost;Port=5432;Database=Hostel;Username=postgres;Password=123"; } }
        public DbSet<AccountPlan> AccountPlans { get; set; } 

        public DbSet<AdditionalOperation> AdditionalOperations { get; set; }

        public DbSet<AdditionalService> AdditionalServices { get; set; }

        public  DbSet<Client> Clients { get; set; }

        public DbSet<JurnalProvodok> JurnalProvodoks { get; set; }

        public DbSet<MainOperation> MainOperations { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public  DbSet<Model.Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(CONNECTION_STRING);
        }

    }
}
