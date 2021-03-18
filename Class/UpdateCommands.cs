using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{
    class UpdateCommands
    {
        Connector connector = new Connector();

        public void Update(List<object> itemsList)
        {

            foreach(object[] row in itemsList)
            {
                var cmdText = $"UPDATE Hockey " +
                    $"SET [Surname] = '{row[1]}', " +
                    $"[Command] = '{row[2]}', " +
                    $"[Count] = {row[3]}, " +
                    $"[Transfers] = {row[4]}, " +
                    $"[Penaltys] = {row[5]} " +
                    $"WHERE [ID] = {row[0]};" ;
                Console.WriteLine(cmdText);
                OleDbCommand updReq = new OleDbCommand(cmdText,connector.getConnection());
                updReq.ExecuteNonQuery();
                connector.disposeConnection();
            }
            
        }
                                                        
    }
}
