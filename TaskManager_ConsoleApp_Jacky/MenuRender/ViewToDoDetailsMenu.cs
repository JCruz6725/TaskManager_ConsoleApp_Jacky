using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class ViewToDoDetailsMenu : MenuComponent
    {
        public required TaskItem Data {  get; set; } 
        public override void DisplayData() {
            Console.WriteLine(Data.Description);

            string status = Data.isOpen ? "Open" : "Closed"; //Processing our bool status into a string
            Console.WriteLine("Status: " + status);

            if (Data.DueDate != null)
            {
                Console.WriteLine("Due Date: " + Data.DueDate);
            }
            else
            {
                Console.WriteLine("(No Current Due Date)");
            }

            Console.WriteLine();
        }
        public override void DisplayOptions() {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Edit Name");
            Console.WriteLine("2. Edit Status");
            Console.WriteLine("3. Edit Description");
            Console.WriteLine("4. Edit Due Date");
            Console.WriteLine("5. Remove Task");
            Console.WriteLine("RETURN. Return to Main Menu");
        }

        public override void DisplayInputFooter()
        {
            base.DisplayInputFooter();
            _Buffer.ViewTaskUserChoice = Console.ReadLine();

        }
    }
}
