using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrganizerB.Forms
{
    public partial class TasksForm : Form
    {
        public TasksForm()=>
            InitializeComponent();

        TaskProcess task = new TaskProcess();

        private void AddTask_Click(object sender, EventArgs e)
        {
            task.AddTask(TaskText.Text,TaskDatePicker.Value);
            TasksForm_Shown(this, e);
        }

        private void TasksForm_Shown(object sender, EventArgs e)
        {
            TasksView.Rows.Clear();
            foreach (TaskRow row in task.GetTasks())
                    TasksView.Rows.Add(row.ID, row.TaskText, row.EndDate.ToShortDateString());
        }

        private void CloseTask_Click(object sender, EventArgs e)
        {
            if (TasksView.SelectedRows.Count == 1)
                task.CloseTask((int)TasksView.SelectedRows[0].Cells[0].Value);
            else MessageBox.Show("Выберите только одну задачу","Ошибка");
            TasksForm_Shown(this, e);
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            var rowEnd = TasksView.Rows.Count;
            var colEnd = TasksView.Rows[0].Cells.Count;
            List<object> itemTable = new List<object>();

            for (int rowIndex = 0; rowIndex < rowEnd - 1; rowIndex++)
            {
                object[] item = new object[6];
                for (int cellIndex = 0; cellIndex < colEnd; cellIndex++)
                {
                    item[cellIndex] = TasksView.Rows[rowIndex].Cells[cellIndex].Value;
                }
                itemTable.Add(item);
            }
            task.EditTask(itemTable);
        }
    }
}
