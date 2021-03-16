using System.Windows.Forms;

namespace OrganizerB
{
    public partial class AboutComands : Form
    {
        public AboutComands()
        {
            
            InitializeComponent();
            StatisticGetter statistic = new StatisticGetter();
            statistic.OnUpdate += update;
        }

        private void update(object Sender, StatisticEventArgs e)
        {
            int indexOf = 1;
            foreach(int goal in e.goals)
            {
                var commandsGoalsViews = Controls.Find($"Command{indexOf}Goal", false);
                Label commandGoalView =(Label)commandsGoalsViews[0];
                commandGoalView.Text = goal.ToString();
                indexOf += 1;
            }

            indexOf = 1;
            foreach(int p in e.penaltys)
            {
                var commandsPenaltysViews = Controls.Find($"Penalty{indexOf}", false);
                Label commandsPenaltyViews = (Label)commandsPenaltysViews[0];
                commandsPenaltyViews.Text = p.ToString();
                indexOf += 1;
            }
            

            GoalsChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            GoalsChart.Series.Add(Command2L.Text);
            GoalsChart.Series.Add(Command3L.Text);
            GoalsChart.Series.Add(Command4L.Text);
            GoalsChart.Series.Add(Command5L.Text);
            GoalsChart.Series[0].LegendText = Command1L.Text;
            GoalsChart.Series[0].Points.Add(int.Parse(Command1Goal.Text));
            GoalsChart.Series[1].Points.Add(int.Parse(Command2Goal.Text));
            GoalsChart.Series[2].Points.Add(int.Parse(Command3Goal.Text));
            GoalsChart.Series[3].Points.Add(int.Parse(Command4Goal.Text));
            GoalsChart.Series[4].Points.Add(int.Parse(Command5Goal.Text));

            PenaltyChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            PenaltyChart.Series.Add(Command2S.Text);
            PenaltyChart.Series.Add(Command3S.Text);
            PenaltyChart.Series.Add(Command4S.Text);
            PenaltyChart.Series.Add(Command5S.Text);
            PenaltyChart.Series[0].LegendText = Command1S.Text;
            PenaltyChart.Series[0].Points.Add(int.Parse(Penalty1.Text));
            PenaltyChart.Series[1].Points.Add(int.Parse(Penalty2.Text));
            PenaltyChart.Series[2].Points.Add(int.Parse(Penalty3.Text));
            PenaltyChart.Series[3].Points.Add(int.Parse(Penalty4.Text));
            PenaltyChart.Series[4].Points.Add(int.Parse(Penalty5.Text));
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
