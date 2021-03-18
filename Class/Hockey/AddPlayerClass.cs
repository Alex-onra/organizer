using System.Data.OleDb;
using System;

namespace OrganizerB
{
    class AddPlayerClass
    {
        Connector connector;

        public AddPlayerClass()
        {
            connector = new Connector();
        }

        public void Add(HockeyRowModel row)
        {
            string addCmd = $"INSERT INTO Hockey([Surname],[Command],[Count],[Transfers],[Penaltys])" +
                $" VALUES ('{row.surname}'" +
                $", '{row.command}' " +
                $", {row.count} " +
                $", {row.transfers} " +
                $", {row.penaltys})";

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
