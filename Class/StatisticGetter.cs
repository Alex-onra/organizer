using System;

namespace OrganizerB
{

    public class StatisticGetter
    {
        public delegate void UpdateDelegate(object o, StatisticEventArgs e);
            public event UpdateDelegate OnUpdate;

        StatisticEventArgs e = new StatisticEventArgs();
            GetCommandsData data = new GetCommandsData();

        public void Get()
        {
            GetGoalsClass goals = new GetGoalsClass();
                e.goals.Clear();
                   e.goals = goals.GetGoals();

            GetPenaltysClass penaltys = new GetPenaltysClass();
                 e.penaltys.Clear();
                    e.penaltys = penaltys.GetPenaltys();

                     e.fullInfo = data.getList();

            if (OnUpdate != null)
                OnUpdate(this, e);

        }
    }
}
