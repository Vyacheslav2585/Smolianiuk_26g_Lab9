namespace lab9
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Thread thread1 = new Thread(() => Application.Run(new Form1()));
            Thread thread2 = new Thread(() => Application.Run(new Form2()));
            Thread thread3 = new Thread(() => Application.Run(new Form3()));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}