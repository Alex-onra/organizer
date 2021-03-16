using System.Data.OleDb;


namespace OrganizerB
{
    class Connector
    {
        private static string connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0; " +
                                                  $"Data Source= ./Resources/DataBase.mdb;";
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
