using Microsoft.EntityFrameworkCore;
using ServicioAutomotriz.Models;

namespace ServicioAutomotriz.Data
{
    public class AppDbContext : DbContext
    {
        // Tablas mapeadas en la base de datos
        public DbSet<Replacement> Replacements { get; set; }
        public DbSet<Service> Services { get; set; }

        // Configura el proveedor MySQL con detección automática de versión
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                DatabaseConnection.ConnectionString,
                ServerVersion.AutoDetect(DatabaseConnection.ConnectionString)
            );
        }
    }
}
