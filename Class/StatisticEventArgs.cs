using System.Collections.Generic;
using System;

namespace OrganizerB
{
    class StatisticEventArgs:EventArgs
    {
        public List<int> goals = new List<int>();
        public List<int> penaltys = new List<int>();
    }
}
