using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    public class TaskManager
    {
        private List<TaskItem> TaskCollection = new();

        public void CreateTask(string title, string description, DateTime dueDate, string status)
        {
            //List<TaskItem> TaskCollection = new List<TaskItem>();
            TaskItem item = new TaskItem(title, description, dueDate, status);
            TaskCollection.Add(item);
        }

        public List<TaskItem> GetallTasks()
        {
            return TaskCollection;
        }
    }
}
