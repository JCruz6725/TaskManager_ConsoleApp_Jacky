using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager_ConsoleApp_Jacky.MenuRender
{
    internal class ViewToDoDetailsMenu : MenuComponent
    {
        public required TaskItem Data {  get; set; } 
        public override void DisplayData() {
            Console.WriteLine(Data.Description);

            string status = Data.isOpen ? "Open" : "Closed"; //Processing our bool status into a string
            Console.WriteLine("Status: " + status);

            if (Data.DueDate != null)
            {
                Console.WriteLine("Due Date: " + Data.DueDate);
            }
            else
            {
                Console.WriteLine("(No Current Due Date)");
            }

            Console.WriteLine();
        }
        public override void DisplayOptions() {
            Console.WriteLine("Options:");
            Console.WriteLine($"{Constant.EDIT_NAME_NUM}. Edit Name");
            Console.WriteLine($"{Constant.EDIT_STATUS_NUM}. Edit Status");
            Console.WriteLine($"{Constant.EDIT_DESCRIPTION_NUM}. Edit Description");
            Console.WriteLine($"{Constant.EDIT_DUE_DATE_NUM}. Edit Due Date");
            Console.WriteLine($"{Constant.REMOVE_NUM}. Remove Task");
            Console.WriteLine($"{Constant.RETURN}. Return to Main Menu");
            Console.WriteLine();
        }

        public override void DisplayInputFooter()
        {
            base.DisplayInputFooter();
            _Buffer.ViewTaskUserChoice = Console.ReadLine();

        }
    }
}
