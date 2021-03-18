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
        public void UpdateGoals(int goalsToR, string command)
        {
            GetCommandsData data = new GetCommandsData();
                var cData = data.getList();
                    var updated = new List<HockeyRowModel>();
            foreach(HockeyRowModel rm in cData)
            {
                if(rm.count>=0&&rm.command==command)
                {
                    HockeyRowModel model = new HockeyRowModel();
                    model.surname = rm.surname;
                    model.command = rm.command;
                    model.transfers = rm.transfers;
                    model.penaltys = rm.penaltys;
                    if (rm.count > goalsToR)
                        model.count = rm.count - goalsToR;
                    else if (rm.count < goalsToR)
                        model.count = rm.count - (goalsToR - Math.Abs(rm.count - goalsToR));
                    else
                        model.count = 0;

                    updated.Add(model);
                }
            }

            foreach (HockeyRowModel row in updated)
            {
                var cmdText = $"UPDATE Hockey " +
                    $"SET [Surname] = '{row.surname}', " +
                    $"[Count] = {row.count}, " +
                    $"[Transfers] = {row.transfers}, " +
                    $"[Penaltys] = {row.penaltys} " +
                    $"WHERE [Command] = '{row.command}';";
                Console.WriteLine(cmdText);
                OleDbCommand updReq = new OleDbCommand(cmdText, connector.getConnection());
                updReq.ExecuteNonQuery();
                connector.disposeConnection();
            }
        }
                                                        
    }
}
