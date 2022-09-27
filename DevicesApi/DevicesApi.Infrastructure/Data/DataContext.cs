using DevicesApi.Core.Entities;
using DevicesApi.Infrastructure.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace DevicesApi.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }

        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<RandomEntity> RandomEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=randomdb;Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RandomEntity>().HasData(RandomEntitySeeder.RandomEntitiesSeeds);
        }
    }
}
