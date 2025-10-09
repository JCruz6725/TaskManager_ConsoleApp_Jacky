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

        public CreateToDoMenu(string inputFooter2, string inputFooter3)
        {
            this.InputFooter2 = inputFooter2;
            this.InputFooter3 = inputFooter3;
 
        }
        public override void DisplayInputFooter() { 
            Console.WriteLine(InputFooter);
            string userInputName = Console.ReadLine();

            //hydrating the buffer with our data to be used later & make sure our data holder is empty
            if (_Buffer.createName == null)
            {
                _Buffer.createName = userInputName;
            }
        }
        public override void DisplayInputFooter2() { 
            Console.WriteLine(InputFooter2);
            string userInputDescription = Console.ReadLine();

            if (_Buffer.createDescription == null)
            {
                _Buffer.createDescription = userInputDescription;
            }
        }
        public override void DisplayInputFooter3()
        {
            Console.WriteLine(InputFooter3);
            string userInputDueDate = Console.ReadLine();

            if (_Buffer.createDueDate == null)
            {
                _Buffer.createDueDate = userInputDueDate;
            }
        }

    }
}
