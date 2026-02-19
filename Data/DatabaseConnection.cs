using Microsoft.Extensions.Configuration;

namespace ServicioAutomotriz.Data
{
    public static class DatabaseConnection
    {
        // Formato: "Server=HOST;Port=3306;Database=TU_BD;Uid=TU_USER;Pwd=TU_PASSWORD;SslMode=Required; (Para azure)"
        public static string ConnectionString { get; } = BuildConnectionString();

        private static string BuildConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            return config.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("No se encontró 'DefaultConnection' en appsettings.json.");
        }
    }
}
