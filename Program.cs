using System;
using System.Windows.Forms;
using movie_reservation_system.UIL.MainScreenUI;

namespace movie_reservation_system
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainScreen());
        }
    }
}