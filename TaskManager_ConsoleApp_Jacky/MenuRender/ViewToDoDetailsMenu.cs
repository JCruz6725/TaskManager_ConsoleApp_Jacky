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
            string status = Data.isOpen ? "Open" : "Closed"; 
            Console.WriteLine("Status: " + status);
            Console.WriteLine(Data.Description);
            Console.WriteLine("Due Date: " + Data.DueDate);
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
            Console.WriteLine();
        }
    }
}
