using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class CreateToDoMenu :MenuComponent
    {
        private string InputFooter2;
        private string InputFooter3;

        public CreateToDoMenu(string inputFooter2, string inputFooter3) { }
        public override void DisplayInputFooter() { }
        public override void DisplayInputFooter2() { }
        public override void DisplayInputFooter3() { }
    }
}
