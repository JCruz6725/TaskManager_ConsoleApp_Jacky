using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager_ConsoleApp_Jacky.MenuRender;

namespace TaskManager_ConsoleApp_Jacky
{
    public class TaskRenderer
    {
        public MenuComponent CurrContext { get; set; }


        public void DisplayMainMenu(List<TaskItem> allTasks) {

            //Create a main menu obj and initialize required params
            CurrContext = new MainMenu() { HeaderTitle = "Main Menu", 
                                           InputFooter = "Enter 0, EXIT, or a Task Number to View:", 
                                           Data = allTasks};
            CurrContext.Template();
            
        }
        public void DisplayCreateToDoItem()
        {
            
        }
        public void DisplayTaskItem(TaskItem taskItem) { }
        public void DisplayEditName(string taskName) { }
        public void DisplayEditStatus(string taskStatus) { }
        public void DisplayEditDescription(string taskDescription) { }
        public void DisplayEditDueDate(DateTime taskDueDate) { }
        public void DisplayRemove(string taskName) { }  
    }
}
