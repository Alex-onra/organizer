using System.Data.OleDb;
using System;

namespace OrganizerB
{
    class AddPlayerClass:IAdd
    {
        Connector connector;

        public AddPlayerClass()
        {
            connector = new Connector();
        }

        public void Add(object[] row)
        {
            string addCmd = $"INSERT INTO Hockey([Surname],[Command],[Count],[Transfers],[Penaltys])" +
                $" VALUES ('{(string)row[0]}'" +
                $", '{(string)row[1]}' " +
                $", {(int)row[2]} " +
                $", {(int)row[3]} " +
                $", {(int)row[4]})";
            //string addCmd = "INSERT INTO Customers(city, cname, cnum) VALUES(‘London’, ‘Hoffman’, 2001);";
            OleDbCommand addPlayerCommand = new OleDbCommand(addCmd, connector.getConnection());

            if (addPlayerCommand.ExecuteNonQuery() != 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error occured!!!!");
                Console.ResetColor();
            }

            connector.disposeConnection();
        }
    }
}
