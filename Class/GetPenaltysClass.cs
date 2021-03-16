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

        foreach (object[] item in data.getList())
        {
            if (item[2].Equals("Авангард"))
                commandsPenaltys[0] += Convert.ToInt32(item[5]);

            else if (item[2].Equals("Автомобилист"))
                commandsPenaltys[1] += Convert.ToInt32(item[5]);

            else if (item[2].Equals("Амур"))
                commandsPenaltys[2] += Convert.ToInt32(item[5]);

            else if (item[2].Equals("Барыс"))
                commandsPenaltys[3] += Convert.ToInt32(item[5]);

            else if (item[2].Equals("Йокерит"))
                commandsPenaltys[4] += Convert.ToInt32(item[5]);
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
