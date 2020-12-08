using Microsoft.EntityFrameworkCore;
using SpoRT.Persistence.Entities;
using System.IO;
using Xamarin.Essentials;

namespace SpoRT.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SportEntity> Sports { get; set; }

        public ApplicationDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "SpoRT.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SportEntity>().HasIndex(x => x.Name).IsUnique();
        }
    }
}