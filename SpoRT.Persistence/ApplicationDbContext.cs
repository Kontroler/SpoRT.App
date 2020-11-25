using Microsoft.EntityFrameworkCore;
using SpoRT.Persistence.Entities;
using System.IO;
using Xamarin.Essentials;

namespace SpoRT.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<SportEntity> Sports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "SpoRT.db3");

            optionsBuilder
                .UseSqlite($"Filename={dbPath}");
        }
    }
}