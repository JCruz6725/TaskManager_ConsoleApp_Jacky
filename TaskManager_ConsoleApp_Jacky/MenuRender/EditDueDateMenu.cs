using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class EditDueDateMenu : MenuComponent
    {
        public required DateTime? Data {  get; set; }
        public override void DisplayData() {
            if (Data != null)
            {
                Console.WriteLine("Current Due Date: " + Data);
            }
            else
            {
                Console.WriteLine("(No Current Due Date)");
            }
            Console.WriteLine();
        }
        public override void DisplayInputFooter()
        {
            base.DisplayInputFooter();

            bool isValidInput = false;
            while (!isValidInput)
            {
                string userInputDueDate = Console.ReadLine();

                //checking if userInput is valid DateTime
                if (DateTime.TryParse(userInputDueDate, out DateTime temp))
                {
                    _Buffer.newDueDate = userInputDueDate;
                    isValidInput = true;
                }
                else if (_Buffer.createDueDate == null && userInputDueDate == "") //if user decides to have no date, dueDate is empty string
                {
                    _Buffer.newDueDate = userInputDueDate;
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
