using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{
    class GetTasks
    {
        Connector connector = new Connector();

        public List<TaskRow> Get()
        {
            List<TaskRow> taskRows = new List<TaskRow>();
            string ReqText = $"SELECT ID, TaskText, EndDate FROM Tasks";
            OleDbCommand getTasks = new OleDbCommand(ReqText, connector.getConnection());
            OleDbDataReader reader = getTasks.ExecuteReader();

            while (reader.Read())
            {
                TaskRow row = new TaskRow();
                row.ID = (int)reader[0];
                row.TaskText = (string)reader[1];
                row.EndDate = (DateTime)reader[2];
                taskRows.Add(row);
            }
            connector.disposeConnection();
            return taskRows;
        }
    }
}
