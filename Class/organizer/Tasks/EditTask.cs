using System.Collections.Generic;
using System.Data.OleDb;


namespace OrganizerB
{
    class EditTask
    {
        public void Edit(List<TaskRow> rows)
        {
            Connector connector = new Connector();

            foreach (TaskRow row in rows)
            {
                var cmdText = $"UPDATE Tasks " +
                    $"SET [TaskText] = '{row.TaskText}', " +
                    $"[EndDate] = '{row.EndDate}' " +
                    $"WHERE [ID] = {row.ID};";

                OleDbCommand updReq = new OleDbCommand(cmdText, connector.getConnection());
                updReq.ExecuteNonQuery();
                connector.disposeConnection();
            }
        }

}
}
