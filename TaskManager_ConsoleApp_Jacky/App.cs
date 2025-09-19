using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    internal class App
    {
        TaskManager Manager = new TaskManager();
        TaskRenderer Display = new TaskRenderer();

        public void Initialize()
        {

        }

        public void MainLoop()
        {
            bool notExit = true;

            while (notExit)
            {
                Display.DisplayMainMenu();

                var createAction = Console.ReadLine();

                switch (createAction)
                {
                    case "1":
                        string taskTitle, taskDescription, taskStatus;
                        DateTime taskDueDate;

                        Display.DisplayCreateItemMenu();

                        Display.DisplayTitleInput();
                        taskTitle = Console.ReadLine();

                        Display.DisplayDescriptionInput();
                        taskDescription = Console.ReadLine();

                        Display.DisplayDueDateInput();
                        taskDueDate = DateTime.Parse(Console.ReadLine());

                        Display.DisplayStatusOption();
                        taskStatus = Console.ReadLine();

                        Manager.CreateTask(taskTitle, taskDescription, taskDueDate, taskStatus);
                        break;
                    case "2":
                        Console.WriteLine("You chose not to create");
                        break;
                    case "EXIT":
                        notExit = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input, try again");
                        break;

                }
            }
        }

        public void Shutdown()
        {

        }
    }
}
