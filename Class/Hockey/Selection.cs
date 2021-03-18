using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;


namespace OrganizerB
{
    enum GroupRows
    {
        Surname,
        Score
    }

    class Selection
    {
        public Selection()
        {

        }

        string tableName { get; set; }

        public string getTableName()
        {
            return tableName;
        }

        public Selection(string tableName)
        {
            this.tableName = tableName;
        }

        Connector connector = new Connector();

        private List<BestPlayerRowModel> Get()
        {
            List<BestPlayerRowModel> selections = new List<BestPlayerRowModel>();
            
            string ReqText = $"SELECT * FROM {tableName}";
            OleDbCommand getReq = new OleDbCommand(ReqText, connector.getConnection());
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                BestPlayerRowModel model = new BestPlayerRowModel((string)(reader[1]),
                                                                     (int)reader[2]);
                selections.Add(model);
            }
            connector.disposeConnection();
            return selections;
        }

        private int GetTablesCount()
        {
            var connection = connector.getConnection();
            int count = 0;
            DataTable tables = connection.GetSchema("Tables", new string[] { null, null, null, "TABLE" });
            foreach (DataRow item in tables.Rows)
            {
                Console.WriteLine(item["TABLE_NAME"]);
                count += 1;
            }
            connection.Close();
            return count;
        }

        public void Add(BestPlayerRowModel model)
        {
            string AppendQuery = $"INSERT INTO {tableName}(SURNAME,SCORE) " +
                $"VALUES('{model.surname}'" +
                        $",'{model.score}')";

            OleDbCommand query = new OleDbCommand(AppendQuery, connector.getConnection());
            query.ExecuteNonQuery();
            connector.disposeConnection();
        }

        public List<BestPlayerRowModel> CreateNewTable(List<BestPlayerRowModel> bestPlayers)
        {

            var Tcount = GetTablesCount();
            tableName = $"Selection{Tcount}";
            var createReq = $"CREATE TABLE {tableName} " +
                $"(ID COUNTER CONSTRAINT PrimaryKey PRIMARY KEY," +
                $"SURNAME VARCHAR" +
                $",SCORE INT)";
            OleDbCommand Reqest = new OleDbCommand(createReq, connector.getConnection());
            Reqest.ExecuteNonQuery();
            connector.disposeConnection();

            foreach (BestPlayerRowModel item in bestPlayers)
            {
                Add(item);
            }
            return Get();
            
        }

        public List<BestPlayerRowModel> GroupBy(GroupRows groupName)
        {
            GetBestPlayers bestPlayers = new GetBestPlayers();
            string GroupRow = groupName.ToString();
            Console.WriteLine(GroupRow);
            CreateNewTable(bestPlayers.Get());
            List<BestPlayerRowModel> selections = new List<BestPlayerRowModel>();
            string ReqText = $"SELECT * FROM {tableName} ORDER BY {GroupRow}";
            OleDbCommand getReq = new OleDbCommand(ReqText, connector.getConnection());
            OleDbDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                var model = new BestPlayerRowModel((string)reader[1], (int)reader[2]);
                selections.Add(model);
            }
            connector.disposeConnection();

            string DropCmd = $"DROP TABLE {tableName}";
            OleDbCommand DropReq = new OleDbCommand(DropCmd, connector.getConnection());
            DropReq.ExecuteNonQuery();
            connector.disposeConnection();
            return selections;
        }
    }
}
