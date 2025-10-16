using Microsoft.VisualBasic;
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

            if (newstatus.Equals(Constant.OPEN))
                TaskCollection[taskIndex].isOpen = true;
            else if (newstatus.Equals(Constant.CLOSE))
                TaskCollection[taskIndex].isOpen = false;

        }

        public void EditTaskTitle(int taskIndex, string newTitle) {

            TaskCollection[taskIndex].Title = newTitle;
        }
        public void EditTaskDescription(int taskIndex, string newDescription) {

            TaskCollection[taskIndex].Description = newDescription;
        }
        public void EditTaskDueDate(int taskIndex, string newDueDate) {

            if (String.IsNullOrEmpty(newDueDate))
            {
                TaskCollection[taskIndex].DueDate = null;
            }
            else
            {
                TaskCollection[taskIndex].DueDate = DateTime.Parse(newDueDate);
            }
        }
        public TaskItem DeleteByIndex(int taskIndex) {
            
            TaskItem temptask = TaskCollection[taskIndex];  
            TaskCollection.RemoveAt(taskIndex);
            return temptask;
        }

        
        //Temporary insert function just for initialization purposes
        public void InsertTask(TaskItem task) { TaskCollection.Add(task); }
    }
}
