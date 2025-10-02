using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class MainMenu : MenuComponent
    {
        public override void DisplayData()
        {
            Console.WriteLine("Current To-Do List:");
            for (int i = 0; i < Data.Count; i++) {
                Console.WriteLine($"1. {Data[i]}");
            }
            Console.WriteLine(""); //empty line for seperation
        }
        public override void DisplayOptions()
        {
            Console.WriteLine("Other Options:");
            Console.WriteLine("0. Create New To-Do Item");
            Console.WriteLine("EXIT, exit");
            Console.WriteLine(""); //empty line for seperation
        }
    }
}
