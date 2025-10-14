using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class EditStatusMenu : MenuComponent
    {
        public required bool Data { get; set; }
        public override void DisplayData() {
            string status = Data ? "Open" : "Closed"; //Processing Data(status) from bool to string

            Console.WriteLine("Current Status: " + status);
            Console.WriteLine();
        }
        public override void DisplayOptions() {
            Console.WriteLine("Options:");
            Console.WriteLine("1. Open");
            Console.WriteLine("2. Closed");
        }
        public override void DisplayInputFooter()
        {
            base.DisplayInputFooter();
            _Buffer.newStatus = Console.ReadLine();
        }
    }
}
