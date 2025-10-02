using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class MainMenu : MenuComponent
    {
        public required List<TaskItem> Data {  get; init; } 
        public override void DisplayData()
        {
            Console.WriteLine("Current To-Do List:");
            for (int i = 0; i < Data.Count; i++) {
                if (Data[i].Status == "Closed" || Data[i].Status == "closed"){
                    Console.WriteLine($"{i + 1}. [X] {Data[i].Title}");
                }
                else if (Data[i].Status == "Open" || Data[i].Status == "open"){
                    Console.WriteLine($"{i + 1}. [ ] {Data[i].Title}");
                }
            }
            Console.WriteLine(""); //empty line for seperation
        }
        public override void DisplayOptions()
        {
            Console.WriteLine("Other Options:");
            Console.WriteLine("0. Create New To-Do Item");
            Console.WriteLine("EXIT. exit");
            Console.WriteLine(""); //empty line for seperation
        }
    }
}
