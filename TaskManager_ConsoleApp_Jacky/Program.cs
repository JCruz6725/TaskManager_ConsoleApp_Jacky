namespace TaskManager_ConsoleApp_Jacky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool notExit = true;

            while (notExit)
            {
                TaskManager manager = new TaskManager();
                TaskRenderer display = new TaskRenderer();
                display.DisplayMainMenu();

                var createAction = Console.ReadLine();

                switch(createAction)
                {
                    case "1":
                        string taskTitle, taskDescription, taskStatus;
                        DateTime taskDueDate;

                        display.DisplayCreateItemMenu();

                        display.DisplayTitleInput();
                        taskTitle = Console.ReadLine();

                        display.DisplayDescriptionInput();
                        taskDescription = Console.ReadLine();

                        display.DisplayDueDateInput();
                        taskDueDate = DateTime.Parse(Console.ReadLine());

                        display.DisplayStatusOption();
                        taskStatus = Console.ReadLine();

                        manager.CreateTask(taskTitle, taskDescription, taskDueDate, taskStatus);
                        break;
                    case "2":
                        Console.WriteLine("You chose not to create");
                        break;
                    case "EXIT":
                        notExit = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input, try again");
                        break;

                }
            }

           


        }
    }
}
