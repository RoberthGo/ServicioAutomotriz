using System;
using System.Data.Common;

namespace AutoRepair.Data
{
    /// <summary>
    /// Lightweight database helper using DbProviderFactory.
    /// By default it reads connection info from environment variables:
    ///   AUTOREPAIR_PROVIDER (e.g. MySql.Data.MySqlClient)
    ///   AUTOREPAIR_CONN (e.g. server=localhost;user id=root;password=yourpw;database=autorepair;)
    /// If not provided, it falls back to common MySQL defaults. Adjust as necessary.
    /// </summary>
    public static class Database
    {
        private static readonly string ProviderName = Environment.GetEnvironmentVariable("AUTOREPAIR_PROVIDER") ?? "MySql.Data.MySqlClient";
        private static readonly string ConnectionString = Environment.GetEnvironmentVariable("AUTOREPAIR_CONN") ?? "server=localhost;user id=root;password=;database=autorepair;";

        public static DbConnection CreateConnection()
        {
            var factory = DbProviderFactories.GetFactory(ProviderName);
            var conn = factory.CreateConnection();
            conn.ConnectionString = ConnectionString;
            return conn;
        }
    }
}
