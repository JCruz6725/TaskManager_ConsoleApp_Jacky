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

        public void CreateTask(string title, string description, string dueDate )
        {
            TaskItem task;
            if (String.IsNullOrEmpty(dueDate))
            {
                task = new TaskItem(title, description);
            }
            else
            {
                task = new TaskItem(title, description) { DueDate = DateTime.Parse(dueDate) };
            }
            TaskCollection.Add(task);
        }
        
        public List<TaskItem> GetAllTask() { 
            var _taskCollection = TaskCollection;
            return _taskCollection; 
        }
        
        public TaskItem GetTaskByIndex(int taskIndex) { 
            TaskItem task = TaskCollection[taskIndex];
            return task; 
        }
        
        public void EditStatusByIndex(int taskIndex, string newstatus) {

            bool status = newstatus.Equals("1"); //? true : false; //Based on TUI, 1=Open 2=Closed

            TaskCollection[taskIndex].isOpen = status;
        }

        public void EditTaskTitle(int taskIndex, string newTitle) { }
        public void EditTaskDescription(int taskIndex, string newDescription) { }
        public void EditTaskDueDate(int taskIndex, string newDueDate) { }
        /*public TaskItem DeleteByIndex(int taskIndex) { }*/

        
        //Temporary insert function just for initialization purposes
        public void InsertTask(TaskItem task) { TaskCollection.Add(task); }
    }
}
