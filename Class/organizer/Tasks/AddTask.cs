using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerB
{
    class AddTask
    {
        Connector connector = new Connector();
        public void Add(TaskRow row)
        {
            var cmdText =
            $"INSERT INTO Tasks([TaskText],[EndDate])" +
            $" VALUES ('{row.TaskText}'" +
            $", '{row.EndDate}')";

            var AddCmd = new OleDbCommand(cmdText, connector.getConnection());
            AddCmd.ExecuteNonQuery();
            connector.disposeConnection();
        }
        
    }
}
