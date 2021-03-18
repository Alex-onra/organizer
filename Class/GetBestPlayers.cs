using System;
using System.Collections.Generic;

namespace OrganizerB
{
    class GetBestPlayers
    {
        GetCommandsData data = new GetCommandsData();

        public List<BestPlayerRowModel> Get()
        {

            List<BestPlayerRowModel> team1 = new List<BestPlayerRowModel>();
                List<BestPlayerRowModel> team2 = new List<BestPlayerRowModel>();
                  List<BestPlayerRowModel> team3 = new List<BestPlayerRowModel>();
                     List<BestPlayerRowModel> team4 = new List<BestPlayerRowModel>();
                        List<BestPlayerRowModel> team5 = new List<BestPlayerRowModel>();
                            List<BestPlayerRowModel> bestPlayers = new List<BestPlayerRowModel>();

            List<BestPlayerRowModel> bestOfTheBest = new List<BestPlayerRowModel>();

            foreach (HockeyRowModel item in data.getList())
            {
                BestPlayerRowModel player = new BestPlayerRowModel();
                player.surname = item.surname;
                player.score = item.count + item.transfers;

                if (item.command.Equals("Авангард"))
                    team1.Add(player);
          
                else if (item.command.Equals("Автомобилист"))
                    team2.Add(player);

                else if (item.command.Equals("Амур"))
                    team3.Add(player);

                else if (item.command.Equals("Барыс"))
                    team4.Add(player);

                else if (item.command.Equals("Йокерит"))
                    team5.Add(player);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("warn! Geted same problem whis a command name!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            team1.Sort();
             team2.Sort();
               team3.Sort();
                 team4.Sort();
                   team5.Sort();

            if (team1.Count > 4)
                for (int p = team1.Count - 1; p > team1.Count - 4; p--)
                    bestPlayers.Add(team1[p]);
            else
                bestPlayers.AddRange(team1);

            if (team2.Count > 4)
                for (int p = team2.Count - 1; p > team1.Count - 4; p--)
                    bestPlayers.Add(team2[p]);
            else
                bestPlayers.AddRange(team2);

            if (team3.Count > 4)
                for (int p = team3.Count - 1; p > team1.Count - 4; p--)
                    bestPlayers.Add(team3[p]);
            else
                bestPlayers.AddRange(team3);

            if (team4.Count > 4)
                for (int p = team4.Count - 1; p > team1.Count - 4; p--)
                    bestPlayers.Add(team4[p]);
            else
                bestPlayers.AddRange(team4);

            if (team5.Count > 4)
                for (int p = team5.Count - 1; p > team1.Count - 4; p--)
                    bestPlayers.Add(team5[p]);
            else
                bestPlayers.AddRange(team5);

            bestPlayers.Sort();

            if (bestPlayers.Count >= 7)
                for (int bestPlayer = bestPlayers.Count - 1; bestPlayer >= bestPlayer - 7; bestPlayer--)
                    bestOfTheBest.Add(bestPlayers[bestPlayer]);
            else return bestPlayers;
            
            return bestOfTheBest; 
        }
       
    }
}
