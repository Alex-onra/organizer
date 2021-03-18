using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{
    class GetCommandsData
    {
        Connector connector = new Connector();

        public List<HockeyRowModel> getList()
        {
            HockeyRowModel hockeyRow;

            string request = "SELECT * FROM Hockey";
            OleDbCommand getCommand = new OleDbCommand(request, connector.getConnection());
            OleDbDataReader GetReq = getCommand.ExecuteReader();
            List<HockeyRowModel> DataList = new List<HockeyRowModel>();
            while (GetReq.Read())
            {
                hockeyRow = new HockeyRowModel( (int)GetReq[0],
                                       (string)GetReq[1],
                                         (string)GetReq[2],
                                            (int)GetReq[3],
                                                (int)GetReq[4],
                                                    (int)GetReq[5]);
                DataList.Add(hockeyRow);
            }
            connector.disposeConnection();
            return DataList;
        }
    }
}
