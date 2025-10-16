using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Buffers;

namespace TaskManager_ConsoleApp_Jacky
{
    public class App
    {
        
        public TaskManager taskManager = new TaskManager();
        public TaskRenderer taskRenderer;
        public Buffer _Buffer;


        public void initialize() {
            taskRenderer = new TaskRenderer(_Buffer = new Buffer());

            TaskItem task1 = new TaskItem("Testing Task 1", "My description for this task is that i need to eat bananas :)", false) { DueDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, 0) };
            taskManager.InsertTask(task1);
            TaskItem task2 = new TaskItem("Testing Task 2", "My description is supposed to explain more details about what this task is about and what I need to do", true);
            taskManager.InsertTask(task2);
            
        }

        public void MainLoop()
        {
            var allTasks = taskManager.GetAllTask();
            taskRenderer.DisplayMainMenu(allTasks);

            int taskCount = allTasks.Count();
            string userAction = Console.ReadLine();

            if (userAction == Constant.EXIT)
            {
                return;
            }
            else if (int.TryParse(userAction, out int taskChoiceIndex) && taskChoiceIndex >= 0 && taskChoiceIndex <= taskCount) //Checks if input is a number && is in range of the number of tasks available
            {
                if (taskChoiceIndex == Constant.CREATE) 
                {
                    taskRenderer.DisplayCreateToDoItem();

                    //Make sure none of the data we are passing is null
                    if ( _Buffer.createName != null && _Buffer.createDescription != null && _Buffer.createDueDate != null)
                    {
                        //Grab all the data we need from our buffer to create our task
                        taskManager.CreateTask(_Buffer.createName, _Buffer.createDescription, _Buffer.createDueDate);
                        _Buffer.clearCreateData(); //Clear our data after we use it
                    }

                    Console.Clear();
                    MainLoop();
                }
                else //view a task number
                {
                    Console.Clear();
                    TaskItem taskUserChose = taskManager.GetTaskByIndex(taskChoiceIndex-1); //use the number user entered to grab the task associated with it
                    
                    taskRenderer.DisplayTaskItem(taskUserChose);

                    string editTaskChoice = _Buffer.ViewTaskUserChoice;

                    switch (editTaskChoice) {
                        case Constant.RETURN:
                            Console.Clear();
                            break;
                        case Constant.EDIT_NAME_NUM: 
                            taskRenderer.DisplayEditName(taskUserChose.Title);
                            taskManager.EditTaskTitle(taskChoiceIndex - 1, _Buffer.newName);
                            break;
                        case Constant.EDIT_STATUS_NUM: 
                            taskRenderer.DisplayEditStatus(taskUserChose.isOpen);
                            taskManager.EditStatusByIndex(taskChoiceIndex - 1, _Buffer.newStatus);
                            break;
                        case Constant.EDIT_DESCRIPTION_NUM: 
                            taskRenderer.DisplayEditDescription(taskUserChose.Description);
                            taskManager.EditTaskDescription(taskChoiceIndex - 1, _Buffer.newDescription);
                            break;
                        case Constant.EDIT_DUE_DATE_NUM: 
                            if (taskUserChose.DueDate == null)
                            {
                                taskRenderer.DisplayEditDueDate(null);
                            }
                            else
                            {
                                taskRenderer.DisplayEditDueDate((DateTime)taskUserChose.DueDate);
                            }
                            taskManager.EditTaskDueDate(taskChoiceIndex - 1, _Buffer.newDueDate);
                            break;
                        case Constant.REMOVE_NUM: 
                            taskRenderer.DisplayRemove(taskUserChose.Title);
                            TaskItem tempTask = taskManager.DeleteByIndex(taskChoiceIndex - 1); //returns the task that was just deleted (for future purposes)
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Press Enter to Return to Main Menu");
                            Console.ReadLine();
                            break;
                    }

                    Console.Clear();
                    MainLoop();
                }
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again.");
                Console.WriteLine();
                MainLoop();
            }
        }

        public void Shutdown() { 
            // SAVE TO FILE
            // OTHER OPERATIONS
        
            Environment.Exit(0);
        
        }
    }
}
