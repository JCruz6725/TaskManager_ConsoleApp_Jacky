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
            base.DisplayInputFooter(); //"Enter in Task Name"

            //hydrating the buffer with our data to be used later & make sure our data holder is empty
            if (_Buffer.createName == null)
            {
                _Buffer.createName = Console.ReadLine();
            }
            Console.WriteLine();
        }
        public override void DisplayInputFooter2() { 
            Console.WriteLine(InputFooter2); //"Enter in Task Description"

            if (_Buffer.createDescription == null)
            {
                _Buffer.createDescription = Console.ReadLine();
            }
            Console.WriteLine();
        }
        public override void DisplayInputFooter3()
        {
            bool isValidInput = false;
            while (!isValidInput) { 
                Console.WriteLine(InputFooter3); //"Enter in Task Due Date"

                string userInputDueDate = Console.ReadLine();

                //checking if Buffer holder is empty & if userInput is valid DateTime
                if (_Buffer.createDueDate == null && DateTime.TryParse(userInputDueDate, out DateTime temp)) 
                {
                    _Buffer.createDueDate = userInputDueDate;
                    isValidInput = true;
                }
                else if (_Buffer.createDueDate == null && userInputDueDate == "") //if user decides to skip date, dueDate is empty string
                {
                    _Buffer.createDueDate = userInputDueDate;
                    isValidInput = true;
                }
                else if (!DateTime.TryParse(userInputDueDate, out DateTime temp1)) //invalid input
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid date format, try again.");
                    isValidInput = false;
                }
            } 
            
        }

    }
}
