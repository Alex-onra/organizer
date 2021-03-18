using System;

namespace OrganizerB
{
    public class BestPlayerRowModel:IComparable
    {
        public BestPlayerRowModel() { }
        public BestPlayerRowModel(string surname, int score)
        {
            this.surname = surname;
            this.score = score;
        }
        public string surname { get; set; }
        public int score { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var otherPlayer = obj as BestPlayerRowModel;
            int result = 0;
            if (otherPlayer!=null)
            {
                if (score > otherPlayer.score)
                    result =  1;
                else if (score < otherPlayer.score)
                    result =  - 1;
                else result =  0;
            }
            return result;
        }
    }
}
