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
                        Console.WriteLine("You chose to create!");
                        ItemDetails _itemDetails = new ItemDetails();
                        _itemDetails = display.DisplayInputItemDetails();

                        manager.CreateTask(_itemDetails._taskName, _itemDetails._taskDescription, DateTime.Parse(_itemDetails._taskDueDate));
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
