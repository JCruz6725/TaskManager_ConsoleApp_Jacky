using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    public class App
    {
        TaskManager Manager = new TaskManager();
        TaskRenderer Display = new TaskRenderer();

        public void initialize() {
            
            TaskItem task1 = new TaskItem("Task 1", "This is a test", new DateTime(2025/01/01), "closed");
            Manager.InsertTask(task1);
            TaskItem task2 = new TaskItem("Task 2", "I need to eat bananas", new DateTime(2025 / 01 / 02), "open");
            Manager.InsertTask(task2);
            
        }

        public void MainLoop()
        {
            var allTasks = Manager.GetAllTask();
            Display.DisplayMainMenu(allTasks);
        }

        public void Shutdown() { }
    }
}
