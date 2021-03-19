using System.Data.OleDb;
using System.Collections.Generic;


namespace OrganizerB
{
    class DeleteContact
    {
        public void Delete(ContactsRow row)
        {
            Connector connector = new Connector();
            var cmdText =  $"DELETE FROM Contacts Where ID = {row.ID}";
            var deleteCmd = new OleDbCommand(cmdText, connector.getConnection());
            deleteCmd.ExecuteNonQuery();
            connector.disposeConnection();
        }
    }
}
