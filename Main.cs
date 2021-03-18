using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
            var rowEnd = CommandsView.Rows.Count;
            var colEnd = CommandsView.Rows[0].Cells.Count;
            List<object> itemTable = new List<object>();

            for (int rowIndex = 0; rowIndex < rowEnd - 1; rowIndex++)
            {
                object[] item = new object[6];
                for (int cellIndex = 0; cellIndex < colEnd; cellIndex++)
                {
                    item[cellIndex] = CommandsView.Rows[rowIndex].Cells[cellIndex].Value;
                }
                itemTable.Add(item);
            }

            UpdateCommands updateCommands = new UpdateCommands();
            updateCommands.Update(itemTable);
            GetUpdate();
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

        private void GetUpdate()
        {
            GetCommandsData data = new GetCommandsData();
            StatisticEventArgs args = new StatisticEventArgs();
            CommandsView.Rows.Clear();
            args.fullInfo = data.getList();
            UpdateDataView(this, args);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            GetUpdate();
        }
    }
}
