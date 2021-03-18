using System;
using System.Collections.Generic;

namespace OrganizerB
{ 
    class GetPenaltysClass
    {
        GetCommandsData data = new GetCommandsData();
        public List<int> GetPenaltys()
        {
        
        int[] commandsPenaltys = { 0, 0, 0, 0, 0 };

        foreach (HockeyRowModel item in data.getList())
        {
            if (item.command.Equals("Авангард"))
                commandsPenaltys[0] += Convert.ToInt32(item.penaltys);

            else if (item.command.Equals("Автомобилист"))
                commandsPenaltys[1] += Convert.ToInt32(item.penaltys);

            else if (item.command.Equals("Амур"))
                commandsPenaltys[2] += Convert.ToInt32(item.penaltys);

            else if (item.command.Equals("Барыс"))
                commandsPenaltys[3] += Convert.ToInt32(item.penaltys);

            else if (item.command.Equals("Йокерит"))
                commandsPenaltys[4] += Convert.ToInt32(item.penaltys);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("warn! Geted same problem whis a command name!!!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
            List<int> penaltys = new List<int>();
                penaltys.AddRange(commandsPenaltys);
                    return penaltys; 
      
        }
    }
}
