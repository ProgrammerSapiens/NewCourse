using Microsoft.Data.SqlClient;

namespace DesignPatterns.Wednesday.Third_Task
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection? _instance = null;
        private static readonly object _lock = new object();
        private SqlConnection? _SqlConnection;
        private string _ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\PotatoKiller\\Documents\\dbIMS.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        private DatabaseConnection() { }

        public static DatabaseConnection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnection();
                    }
                    return _instance;
                }
            }
        }

        public void Connect()
        {
            lock (_lock)
            {
                if (_SqlConnection == null)
                {
                    _SqlConnection = new SqlConnection(_ConnectionString);
                    _SqlConnection.Open();
                    Console.WriteLine("Connection opened.");
                }
                else
                {
                    Console.WriteLine("Connection already opened.");
                }
            }
        }

        public void Disconnect()
        {
            lock (_lock)
            {
                if (_SqlConnection != null && _SqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _SqlConnection.Close();
                    Console.WriteLine("Connection closed.");
                }
            }
        }
    }
}
