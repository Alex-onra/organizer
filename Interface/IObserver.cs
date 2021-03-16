using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizerB
{
    interface IObserver
    {
        void update(List<int> goals, List<int> penaltys);
    }
}
