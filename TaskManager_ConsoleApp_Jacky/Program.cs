namespace TaskManager_ConsoleApp_Jacky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.initialize();
            app.MainLoop();
            app.Shutdown();
        }
    }
}
