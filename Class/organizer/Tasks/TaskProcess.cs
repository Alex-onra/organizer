using System;
using System.Collections.Generic;

namespace OrganizerB
{
    class TaskProcess
    {
        AddTask addTask = new AddTask();
        GetTasks getTasks = new GetTasks();
        EditTask editTasks = new EditTask();
        CloseTask closeTask = new CloseTask();

        public void AddTask(string task, DateTime date)
        {
            TaskRow row = new TaskRow();
            row.TaskText = task;
            row.EndDate = date;
            addTask.Add(row);
        }

        public List<TaskRow> GetTasks()
        {
            return getTasks.Get();
        }

        public void EditTask(List<object> tasks)
        {
            List<TaskRow> taskRows = new List<TaskRow>();

            foreach (object[] task in tasks)
            {
                TaskRow row = new TaskRow();
                row.ID = (int)task[0];
                row.TaskText = (string)task[1];
                row.EndDate = DateTime.Parse((string)task[2]);
                taskRows.Add(row);
            }
            editTasks.Edit(taskRows);
        }

        public void CloseTask(int id)
        {
            TaskRow row = new TaskRow();
            row.ID = id;
            closeTask.Close(row);
        }
    }
}
