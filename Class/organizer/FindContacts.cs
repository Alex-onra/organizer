using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{
    class FindContacts
    {
        public List<ContactsRow>FindByName(string name)
        {
            Connector connector = new Connector();
            var cmd = $"SELECT * FROM Contacts WHERE [Surname] LIKE '%{name}%'";
            OleDbCommand findedRows = new OleDbCommand(cmd, connector.getConnection());
            var reader = findedRows.ExecuteReader();
            var findedList = new List<ContactsRow>();

            while (reader.Read())
            {
                var contactRow = new ContactsRow();
                contactRow.ID = (int)reader[0];
                contactRow.name = (string)reader[1];
                contactRow.phone = (string)reader[2];
                findedList.Add(contactRow);
            }
            connector.disposeConnection();
            return findedList;
        }

        public List<ContactsRow> FindByPhone(string phone)
        {
            Connector connector = new Connector();
            var cmd = $"SELECT * FROM Contacts WHERE [Phone] LIKE '%{phone}%'";
            OleDbCommand findedRows = new OleDbCommand(cmd, connector.getConnection());
            var reader = findedRows.ExecuteReader();
            var findedList = new List<ContactsRow>();

            while (reader.Read())
            {
                var contactRow = new ContactsRow();
                contactRow.ID = (int)reader[0];
                contactRow.name = (string)reader[1];
                contactRow.phone = (string)reader[2];
                findedList.Add(contactRow);
            }
            connector.disposeConnection();
            return findedList;
        }
    }
}
