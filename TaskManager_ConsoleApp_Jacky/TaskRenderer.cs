using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky
{
    public struct ItemDetails
    {
        public string _taskName;
        public string _taskDueDate;
        public string _taskDescription;
    }
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

        public ItemDetails DisplayInputItemDetails()
        {
            ItemDetails _itemDetails = new ItemDetails();
            Console.WriteLine("=======================");
            Console.WriteLine("=  Create To-Do Item  =");
            Console.WriteLine("=======================");
            Console.WriteLine("Enter in Task Name: ");
            _itemDetails._taskName = Console.ReadLine();
            Console.WriteLine("Enter in Task Due Date (ex. Jan 1, 2009): ");
            _itemDetails._taskDueDate = Console.ReadLine();
            Console.WriteLine("Enter in Task Description: ");
            _itemDetails._taskDescription = Console.ReadLine();

            return _itemDetails;
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
