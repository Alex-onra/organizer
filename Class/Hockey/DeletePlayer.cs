using System.Data.OleDb;


namespace OrganizerB
{
    class DeletePlayer
    {
        Connector connector = new Connector();
        public void Delete(int row)
        {
            string delQuery = $"DELETE FROM Hockey Where ID = {row}";
                OleDbCommand dbCommand = new OleDbCommand(delQuery, connector.getConnection());
                 dbCommand.ExecuteNonQuery();
                    connector.disposeConnection();
        }
        public void DeleteByPenaltys(int max)
        {
            string delQuery = $"DELETE FROM Hockey Where Penaltys > {max}";
            OleDbCommand dbCommand = new OleDbCommand(delQuery, connector.getConnection());
            dbCommand.ExecuteNonQuery();
            connector.disposeConnection();
        }
    }
}
