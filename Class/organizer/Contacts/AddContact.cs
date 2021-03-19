using System.Data.OleDb;

namespace OrganizerB
{
    class AddContact
    {
        public void Add(ContactsRow row)
        {
            Connector connector = new Connector();

            var cmdText =
                $"INSERT INTO Contacts([Surname],[Phone])" +
                $" VALUES ('{row.name}'" +
                $", '{row.phone}')";
            var AddCmd = new OleDbCommand(cmdText, connector.getConnection());
            AddCmd.ExecuteNonQuery();
            connector.disposeConnection();
        }
    }
}
