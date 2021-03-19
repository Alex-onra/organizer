using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{
    class GetAllContacts
    {
        Connector connector = new Connector();

        public List<ContactsRow> Get()
        {
            var cmdText = "SELECT * FROM Contacts";
            OleDbCommand getCmd = new OleDbCommand(cmdText, connector.getConnection());
            var reader = getCmd.ExecuteReader();
            var contactsList = new List<ContactsRow>();
            while(reader.Read())
            {
                var contact = new ContactsRow();
                contact.ID = (int)reader[0];
                contact.name = (string)reader[1];
                contact.phone = (string)reader[2];
                contactsList.Add(contact);
            }
            connector.disposeConnection();
            return contactsList;
        }
    }
}
