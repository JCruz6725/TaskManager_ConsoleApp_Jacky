using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    public abstract class MenuComponent
    {
        public required string HeaderTitle { get; init; }
        public List<string> Data { get; init; } = new List<string>();
        public List<string> Options { get; init; } = new List<string>();
        public required string InputFooter { get; init; }

        //CONSTRUCTORS
        public MenuComponent() { }
        public MenuComponent(string headerTitle, List<string> data, List<string> options, string inputFooter) { }
        public MenuComponent(string headerTitle, List<string> data, string inputFooter) { }
        public MenuComponent(string headerTitle, string inputFooter) { }
        
        //METHODS
        public void Template() { }
        public virtual void DisplayMenuHeader() { }
        public virtual void DisplayData() { }
        public virtual void DisplayOptions() { }   
        public virtual void DisplayInputFooter() { }
        public virtual void DisplayInputFooter2() { }
        public virtual void DisplayInputFooter3() { }
    }
}
