using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    public class TaskManager
    {
        private List<TaskItem> TaskCollection;

        public void CreateTask(string title, string Description, DateTime DueDate) { }
        /*
        public List<TaskItem> GetAllTask() { }
        public TaskItem GetTaskByIndex(int taskIndex) { }
        */
        public void EditStatusByIndex(int taskIndex, string newstatus) { }
        public void EditTaskTitle(int taskIndex, string newTitle) { }
        public void EditTaskDescription(int taskIndex, string newDescription) { }
        public void EditTaskDueDate(int taskIndex, string newDueDate) { }
        /*public TaskItem DeleteByIndex(int taskIndex) { }*/
    }
}
