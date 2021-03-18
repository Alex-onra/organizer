using System;
using System.Collections.Generic;

namespace OrganizerB
{
    class GetGoalsClass
    {
        GetCommandsData data = new GetCommandsData();

        public List<int> GetGoals()
        {

            int[] commandsGoals = { 0, 0, 0, 0, 0 };

            foreach (HockeyRowModel item in data.getList())
            {
                if (item.command.Equals("Авангард"))
                    commandsGoals[0] += Convert.ToInt32(item.count);

                else if (item.command.Equals("Автомобилист"))
                    commandsGoals[1] += Convert.ToInt32(item.count);

                else if (item.command.Equals("Амур"))
                    commandsGoals[2] += Convert.ToInt32(item.count);

                else if (item.command.Equals("Барыс"))
                    commandsGoals[3] += Convert.ToInt32(item.count);

                else if (item.command.Equals("Йокерит"))
                    commandsGoals[4] += Convert.ToInt32(item.count);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("warn! Geted same problem whis a command name!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            List<int> goals = new List<int>();
            goals.AddRange(commandsGoals);
            return goals;
        }
    }
}
