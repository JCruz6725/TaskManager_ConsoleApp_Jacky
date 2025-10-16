using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class EditNameMenu : MenuComponent
    {
        public required string Data { get; set; }
        public override void DisplayData() {
            Console.WriteLine("Current Name: " + Data);
            Console.WriteLine();
        }
        public override void DisplayInputFooter()
        {
            base.DisplayInputFooter();
            _Buffer.newName = Console.ReadLine();
        }
    }
}
