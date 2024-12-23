using DotNetEnv;

using System.Net;


namespace EZReserve
{
    internal static partial class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Env.Load();
            ApplicationConfiguration.Initialize();


           
            Application.Run(new MainMenu());
        }
    }
}