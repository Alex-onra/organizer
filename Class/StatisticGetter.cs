using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace OrganizerB
{

    class StatisticGetter
    {
        public event EventHandler<StatisticEventArgs> OnUpdate;

        StatisticEventArgs e;

        GetCommandsData data = new GetCommandsData();
       

        private void GetGoals()
        {
            e.goals.Clear();
            int[] commandsGoals = {0,0,0,0,0}; 

            foreach (object[] item in data.getList())
            {
                if(item[2].Equals("Авангард"))
                    commandsGoals[0] += Convert.ToInt32(item[4]);
                
                else if (item[2].Equals("Автомобилист"))
                    commandsGoals[1] += Convert.ToInt32(item[4]);

                else if (item[2].Equals("Амур"))
                    commandsGoals[3] += Convert.ToInt32(item[4]);

                else if (item[2].Equals("Барыс"))
                    commandsGoals[4] += Convert.ToInt32(item[4]);
                
                else if (item[2].Equals("Йокерит"))
                    commandsGoals[5] += Convert.ToInt32(item[4]);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("warn! Geted same problem whis a command name!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                    
            }
            e.goals.AddRange(commandsGoals);
        }

        private void GetPenaltys()
        {
            e.penaltys.Clear();
            int[] commandsPenaltys = { 0, 0, 0, 0, 0 };

            foreach (object[] item in data.getList())
            {
                if (item[2].Equals("Авангард"))
                    commandsPenaltys[0] += Convert.ToInt32(item[4]);

                else if (item[2].Equals("Автомобилист"))
                    commandsPenaltys[1] += Convert.ToInt32(item[4]);

                else if (item[2].Equals("Амур"))
                    commandsPenaltys[3] += Convert.ToInt32(item[4]);

                else if (item[2].Equals("Барыс"))
                    commandsPenaltys[4] += Convert.ToInt32(item[4]);

                else if (item[2].Equals("Йокерит"))
                    commandsPenaltys[5] += Convert.ToInt32(item[4]);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("warn! Geted same problem whis a command name!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            e.penaltys.AddRange(commandsPenaltys);
        }

        public void getAll()
        {
            GetGoals();
            GetPenaltys();
            update(e);
        }

        private void update(StatisticEventArgs e)
        {
            EventHandler<StatisticEventArgs> handler = OnUpdate;
            if(handler!=null)
            {
                handler(this, e);
            }
        }
    }
}
