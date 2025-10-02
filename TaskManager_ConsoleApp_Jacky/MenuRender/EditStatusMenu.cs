using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class EditStatusMenu : MenuComponent
    {
        public required string Data { get; set; }
        public override void DisplayData() { }
        public override void DisplayOptions() { }
    }
}
