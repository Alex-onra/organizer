using System;
using System.Windows.Forms;

namespace OrganizerB
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }
        public StatisticGetter statistic = new StatisticGetter();

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {

            AddPlayerClass addPlayer = new AddPlayerClass();
            if (SurnameText.TextLength != 0 &&
                GoalsText.TextLength != 0 &&
                TransfersText.TextLength != 0 &&
                PenaltysText.TextLength != 0)
            {
                try
                {
                    HockeyRowModel row = new HockeyRowModel();
                    row.surname = SurnameText.Text;
                    row.command = AddCommandNames.Text;
                    row.count = Convert.ToInt32(GoalsText.Text);
                    row.transfers = Convert.ToInt32(TransfersText.Text);
                    row.penaltys = Convert.ToInt32(PenaltysText.Text);

                    addPlayer.Add(row);
                    AboutComands aboutComands = (AboutComands)Application.OpenForms["AboutComands"];
                    if (aboutComands != null)
                        aboutComands.Register();

                    statistic.Get();
                }
                catch
                {
                    MessageBox.Show("Проверьте правильность ввода данных и повторите попытку", "Ошибка!");
                }

            }

        }
    }
}
