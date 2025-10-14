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

        private Buffer _Buffer;

        public TaskRenderer(Buffer _Buffer) { this._Buffer = _Buffer; }


        public void DisplayMainMenu(List<TaskItem> allTasks) {

            //Create a main menu obj and initialize required params
            CurrContext = new MainMenu() { HeaderTitle = "Main Menu", 
                                           InputFooter = "Enter 0, EXIT, or a Task Number to View:", 
                                           Data = allTasks};
            CurrContext.Template();
            
        }
        public void DisplayCreateToDoItem(){

            CurrContext = new CreateToDoMenu("Enter in Task Description:", "Enter in Task Due Date (mm/dd/yyyy) (Press enter to skip):") {
                                              HeaderTitle = "Create-To Do Item",
                                              InputFooter = "Enter in Task Name:",
                                              _Buffer = this._Buffer};
            CurrContext.Template();
        }
        public void DisplayTaskItem(TaskItem taskItem) {

            CurrContext = new ViewToDoDetailsMenu() { HeaderTitle = $"{taskItem.Title}", 
                                                      InputFooter = "Enter 1, 2, 3, 4, 5, or RETURN" , 
                                                      Data = taskItem, 
                                                      _Buffer = this._Buffer};
            CurrContext.Template();
        }
        public void DisplayEditName(string taskName) { }
        public void DisplayEditStatus(bool taskStatus) {

            CurrContext = new EditStatusMenu() { HeaderTitle = "Edit Status", 
                                                 InputFooter = "Enter 1 or 2:",
                                                 Data = taskStatus, 
                                                 _Buffer = this._Buffer};
            CurrContext.Template(); 
        }
        public void DisplayEditDescription(string taskDescription) { }
        public void DisplayEditDueDate(DateTime taskDueDate) { }
        public void DisplayRemove(string taskName) { }  
    }
}
