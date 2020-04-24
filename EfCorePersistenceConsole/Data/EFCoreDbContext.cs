using EfCorePersistenceConsole.Configurations;
using EfCorePersistenceConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCorePersistenceConsole.Data
{
    public class EFCoreDbContext : DbContext
    {
        public EFCoreDbContext()
        {

        }

        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new OrderConfiguration());
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=.;Database=ValueObjectPersistenceDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
