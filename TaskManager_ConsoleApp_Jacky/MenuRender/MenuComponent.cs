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
        public required string InputFooter { get; init; }

        //Template outlines subsequent order that methods are called
        public void Template()
        {
            DisplayMenuHeader();
            DisplayData();
            DisplayOptions();
            DisplayInputFooter();
            DisplayInputFooter2();
            DisplayInputFooter3();
        }
        public virtual void DisplayMenuHeader()
        {
            Console.WriteLine("===============");
            Console.WriteLine($"=  {HeaderTitle}  =");
            Console.WriteLine("===============");
        }
        public virtual void DisplayData() { }
        public virtual void DisplayOptions() { }   
        public virtual void DisplayInputFooter()
        {
            Console.WriteLine(InputFooter);
        }
        public virtual void DisplayInputFooter2() { }
        public virtual void DisplayInputFooter3() { }
    }
}
