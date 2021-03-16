using System.Data.OleDb;


namespace OrganizerB
{
    class Connector
    {
        private static string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; " +
                                                  $"Data Source=DataBase.accdb;" +
                                                        $"Persist Security Info=False;";
        private OleDbConnection connection = new OleDbConnection(connectionString);

        public OleDbConnection getConnection()
        {
            connection.Open();
            return connection;
        }

        public void disposeConnection()
        {
            connection.Close();
        }
    }
}
