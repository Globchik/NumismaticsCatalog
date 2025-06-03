using NumismaticsCatalog.ApplicationData;
using System;
using System.Windows.Forms;

namespace NumismaticsCatalog
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                UserData.LoadSavedData();
            }
            catch (Exception)
            {
                //no saved data - empty UserData
            }
            Application.Run(new FormMainMenu());
        }
    }
}