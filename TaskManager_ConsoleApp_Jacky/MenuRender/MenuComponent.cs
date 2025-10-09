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

        public Buffer _Buffer {  get; init; }

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
            for (int i =0; i<HeaderTitle.Length+6; i++) //Outputs border in relative length to header title length
            {
                Console.Write("=");
            }
            Console.WriteLine("");

            Console.WriteLine($"=  {HeaderTitle}  =");

            for (int i = 0; i < HeaderTitle.Length + 6; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("");
        }
        public virtual void DisplayData() { }
        public virtual void DisplayOptions() 
        { 
            Console.WriteLine("Options: "); 
        }   
        public virtual void DisplayInputFooter()
        {
            Console.WriteLine(InputFooter);
        }
        public virtual void DisplayInputFooter2() { }
        public virtual void DisplayInputFooter3() { }
    }
}
