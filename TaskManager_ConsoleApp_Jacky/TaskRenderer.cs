using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    public class TaskRenderer
    {
        
        public void DisplayMainMenu()
        {
            Console.WriteLine("===============");
            Console.WriteLine("=  Main Menu  =");
            Console.WriteLine("===============");
            Console.WriteLine("Options:");
            Console.WriteLine("1. Create New To-Do Item");
            Console.WriteLine("2. View All Current To-Do Items");
            Console.WriteLine("EXIT. exit\n");
            Console.WriteLine("Enter 1, 2, or EXIT: ");

        }

        public void DisplayCreateItemMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=  Create To-Do Item  =");
            Console.WriteLine("=======================");
        }

        public void DisplayTitleInput()
        {
            Console.WriteLine("Enter in Task Name: ");
        }

        public void DisplayDescriptionInput()
        {
            Console.WriteLine("\nEnter in Task Description: ");
        }

        public void DisplayDueDateInput()
        {
            Console.WriteLine("\nEnter in Task Due Date (ex. Jan 1, 2009): ");
        }

        public void DisplayStatusOption()
        {
            Console.WriteLine("\nChoose the status of your task: ");
            Console.WriteLine("1. Open\n2. Closed\n");
            Console.WriteLine("Enter 1 or 2: ");
        }


        public void DisplayAll(List<TaskItem> allTasks)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("=  All Current To-Do Items  =");
            Console.WriteLine("=============================");

            for (int i = 0; i < allTasks.Count; i++)
            {
                Console.WriteLine(allTasks[i].Title);
            }
        }
    }
}
