using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{
    class GetCommandsData
    {
        Connector connector = new Connector();

        public List<object> getList()
        {
            string request = "SELECT * FROM Hockey";
            OleDbCommand getCommand = new OleDbCommand(request, connector.getConnection());
            OleDbDataReader GetReq = getCommand.ExecuteReader();
            List<object> DataList = new List<object>();
            while (GetReq.Read())
            {
                object[] itemArray = {GetReq[0],
                                       GetReq[1],
                                         GetReq[2],
                                            GetReq[3],
                                                GetReq[4],
                                                    GetReq[5]};
                DataList.Add(itemArray);
            }
            connector.disposeConnection();
            return DataList;
        }
    }
}
