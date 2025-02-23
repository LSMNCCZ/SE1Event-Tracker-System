using ADET_sample;
using MySql.Data.MySqlClient;

namespace ADET_sample
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Log_In());
        }
    }

    public class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connstring = "server = localhost;uid=root;pwd=SQLKoTo05!;database=event_management_system;"; // Change pwd according to password ng local db niyo sa sql
            return new MySqlConnection(connstring);
        }
    }

    public static class GlobalVariables
    {
        public static string UserRole { get; set; }
    }
}