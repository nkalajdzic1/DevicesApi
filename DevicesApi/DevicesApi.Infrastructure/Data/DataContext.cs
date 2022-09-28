using DevicesApi.Core.Classes;
using DevicesApi.Core.Entities;
using DevicesApi.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;

namespace DevicesApi.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(): base() { }
        public DataContext(DbContextOptions<DataContext> options): base(options) {}

        public DbSet<DeviceEntity> DeviceEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed initial data for the database
            modelBuilder.Entity<DeviceEntity>().HasData(DeviceEntitySeeder.DeviceEntitySeeds);
        }
    }
}
