using System.Collections.Generic;
using System;

namespace OrganizerB
{
    public class StatisticEventArgs:EventArgs
    {
        public List<int> goals = new List<int>();
        public List<int> penaltys = new List<int>();
        public List<object> fullInfo = new List<object>();
    }
}
