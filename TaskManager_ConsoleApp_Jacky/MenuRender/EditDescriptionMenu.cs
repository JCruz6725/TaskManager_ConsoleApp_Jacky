using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class EditDescriptionMenu : MenuComponent
    {
        public required string Data { get; set; }
        public override void DisplayData() {
            Console.WriteLine("Current Description:");
            Console.WriteLine();
            Console.WriteLine(Data);
            Console.WriteLine();
        }
        public override void DisplayInputFooter()
        {
            base.DisplayInputFooter();
            _Buffer.newDescription = Console.ReadLine();
        }
    }
}
