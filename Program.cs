using NumismaticsCatalog.AppData;

namespace NumismaticsCatalog
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
            TestData.LoadTestData();
            Application.Run(new MainForm());
        }
    }
}