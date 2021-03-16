using System;
using System.Windows.Forms;

namespace OrganizerB
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutComands about = new AboutComands();
            about.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer();
            addPlayer.Show();
            addPlayer.statistic.OnUpdate += UpdateDataView;
        }

        public void UpdateDataView(object sender, StatisticEventArgs e)
        {
            CommandsView.Rows.Clear();
                foreach(object[] row in e.fullInfo)
                            CommandsView.Rows.Add(row[0],
                                                    row[1],
                                                        row[2],
                                                            row[3],
                                                                row[4],
                                                                    row[5]);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeletePlayer del = new DeletePlayer();
            if (CommandsView.SelectedRows.Count == 1)
            {
                int id = (int)CommandsView.SelectedRows[0].Cells[0].Value;
                del.Delete(id);

            }
            else
                MessageBox.Show("Выберите только одну строку!", "Ошибка");
            
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            GetCommandsData data = new GetCommandsData();
                StatisticEventArgs args = new StatisticEventArgs();

            args.fullInfo = data.getList();
                UpdateDataView(this, args);
        }
    }
}
