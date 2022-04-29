using Utility.Dal;
using Utility.Managers;
using WinFormsApp.Forms;

namespace WinFormsApp
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
            if (FileRepository.SettingsExists())
            {
                SettingsManager.LoadSettings();
            }
            Application.Run(FileRepository.SettingsExists() ? new MainForm() : new WelcomeForm());
        }
    }
}