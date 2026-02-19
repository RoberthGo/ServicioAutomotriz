using Microsoft.EntityFrameworkCore;
using ServicioAutomotriz.Models;

namespace ServicioAutomotriz.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Replacement> Replacements { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                DatabaseConnection.ConnectionString,
                ServerVersion.AutoDetect(DatabaseConnection.ConnectionString)
            );
        }
    }
}
