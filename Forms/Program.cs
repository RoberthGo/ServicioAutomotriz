using ServicioAutomotriz.Data;

namespace ServicioAutomotriz.Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (!TestConnection())
                return;

            Application.Run(new MainForm());
        }

        private static bool TestConnection()
        {
            try
            {
                using var db = new AppDbContext();
                db.Database.CanConnect();
                MessageBox.Show(
                    "Conexión exitosa a la base de datos.",
                    "Conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo conectar a la base de datos:\n\n{ex.Message}",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}