using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Buffers;

namespace TaskManager_ConsoleApp_Jacky
{
    public class App
    {
        
        public TaskManager Manager = new TaskManager();
        public TaskRenderer Display;
        public Buffer _Buffer;


        public void initialize() {
            Display = new TaskRenderer(_Buffer = new Buffer());

            TaskItem task1 = new TaskItem("Task 1", "This is a test", new DateTime(2025/01/01), false);
            Manager.InsertTask(task1);
            TaskItem task2 = new TaskItem("Task 2", "I need to eat bananas", new DateTime(2025 / 01 / 02), true);
            Manager.InsertTask(task2);
            
        }

        public void MainLoop()
        {
            var allTasks = Manager.GetAllTask();
            Display.DisplayMainMenu(allTasks);

            int taskCount = allTasks.Count();
            string userAction = Console.ReadLine();

            if (userAction == "EXIT")
            {
                return;
            }
            else if (int.TryParse(userAction, out int num) && num >= 0 && num <= taskCount) //Checks if input is a number && is in range of the number of tasks available
            {
                if (num == 0) //create
                {
                    Display.DisplayCreateToDoItem();

                    //Make sure none of the data we are passing is null
                    if ( _Buffer.createName != null && _Buffer.createDescription != null && _Buffer.createDueDate != null)
                    {
                        //Grab all the data we need from our buffer to create our task
                        Manager.CreateTask(_Buffer.createName, _Buffer.createDescription, _Buffer.createDueDate);
                        _Buffer.clearCreateData(); //Clear our data after we use it
                    }

                    Console.Clear();
                    MainLoop();
                }
                else //view a task number
                {

                }
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again.");
                Console.WriteLine("");
                MainLoop();
            }
        }

        public void Shutdown() { }
    }
}
