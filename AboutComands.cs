using System.Windows.Forms;
using System;
using System.Threading;

namespace OrganizerB
{
    public partial class AboutComands : Form
    {
        public AboutComands()
        {

            InitializeComponent();


        }

        private void update(object sender, StatisticEventArgs e)
        {
            int indexOf = 1;
            int maxGoal = 0;
            foreach (int goal in e.goals)
            {
                if (goal > maxGoal) maxGoal = goal;
                Label commandGoalView = (Label)splitContainer1.Panel1.Controls[$"Command{indexOf}Goal"];
                commandGoalView.Text = goal.ToString();
                indexOf += 1;
            }

            indexOf = 1;
            int maxPenalty = 0;
            foreach (int p in e.penaltys)
            {
                if (p > maxPenalty) maxPenalty = p;
                Label commandsPenaltyViews = (Label)splitContainer2.Panel1.Controls[$"Penalty{indexOf}"];
                commandsPenaltyViews.Text = p.ToString();
                indexOf += 1;
            }
            GoalsChart.Series.Clear();
            GoalsChart.ChartAreas[0].AxisY.Maximum = maxGoal;
            GoalsChart.Series.Add(Command1L.Text);
            GoalsChart.Series.Add(Command2L.Text);
            GoalsChart.Series.Add(Command3L.Text);
            GoalsChart.Series.Add(Command4L.Text);
            GoalsChart.Series.Add(Command5L.Text);
            GoalsChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            GoalsChart.Series[0].Points.Add(int.Parse(Command1Goal.Text));
            GoalsChart.Series[1].Points.Add(int.Parse(Command2Goal.Text));
            GoalsChart.Series[2].Points.Add(int.Parse(Command3Goal.Text));
            GoalsChart.Series[3].Points.Add(int.Parse(Command4Goal.Text));
            GoalsChart.Series[4].Points.Add(int.Parse(Command5Goal.Text));


            PenaltyChart.Series.Clear();
            PenaltyChart.ChartAreas[0].AxisY.Maximum = maxPenalty;
            PenaltyChart.Series.Add(Command1S.Text);
            PenaltyChart.Series.Add(Command2S.Text);
            PenaltyChart.Series.Add(Command3S.Text);
            PenaltyChart.Series.Add(Command4S.Text);
            PenaltyChart.Series.Add(Command5S.Text);
            PenaltyChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            PenaltyChart.Series[0].Points.Add(int.Parse(Penalty1.Text));
            PenaltyChart.Series[1].Points.Add(int.Parse(Penalty2.Text));
            PenaltyChart.Series[2].Points.Add(int.Parse(Penalty3.Text));
            PenaltyChart.Series[3].Points.Add(int.Parse(Penalty4.Text));
            PenaltyChart.Series[4].Points.Add(int.Parse(Penalty5.Text));

            BestView.Rows.Clear();
            foreach (BestPlayerRowModel player in e.bestPlayers)
            {
                BestView.Rows.Add(player.surname, player.score);
            }
        }

        public void Register()
        {
            AddPlayer pf = (AddPlayer)Application.OpenForms["AddPlayer"];
            pf.statistic.OnUpdate += update;
        }

        private void AboutComands_Shown(object sender, EventArgs e)
        {
            StatisticEventArgs args = new StatisticEventArgs();
                GetGoalsClass getGoals = new GetGoalsClass();
                    GetPenaltysClass getPenaltys = new GetPenaltysClass();

            args.goals = getGoals.GetGoals();
            args.penaltys = getPenaltys.GetPenaltys();
            update(this, args);
        }

        private void AboutComands_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AddPlayer pf = (AddPlayer)Application.OpenForms["AddPlayer"];
                pf.statistic.OnUpdate -= update;
            }
            catch 
            {
                Console.WriteLine("Ошибка отписки! Юзер дропнул форму добавления");
            }
        }
    }
}
