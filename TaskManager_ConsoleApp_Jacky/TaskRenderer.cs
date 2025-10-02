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
        MenuComponent CurrContext;

        public void DisplayMainMenu(List<TaskItem> allTasks) {
            MainMenu mainMenu = new MainMenu() { HeaderTitle = "Main Menu", InputFooter = "Enter" };
        }
        public void DisplayCreateToDoItem() { }
        public void DisplayTaskItem(TaskItem taskItem) { }
        public void DisplayEditName(string taskName) { }
        public void DisplayEditStatus(string taskStatus) { }
        public void DisplayEditDescription(string taskDescription) { }
        public void DisplayEditDueDate(DateTime taskDueDate) { }
        public void DisplayRemove(string taskName) { }  
    }
}
