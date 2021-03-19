using System.Data.OleDb;


namespace OrganizerB
{
    class CloseTask
    {
        public void Close(TaskRow row)
        {
            Connector connector = new Connector();
            var cmdText = $"DELETE FROM Tasks Where ID = {row.ID}";
            var deleteCmd = new OleDbCommand(cmdText, connector.getConnection());
            deleteCmd.ExecuteNonQuery();
            connector.disposeConnection();
        }
    }
}
