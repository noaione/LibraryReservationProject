using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryReservation
{
    static class Program
    {
        // Based on:
        // https://stackoverflow.com/a/32774750
        private static readonly ApplicationContext MainContext = new ApplicationContext();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Based on:
            // https://stackoverflow.com/a/32774750
            MainContext.MainForm = new frmLogin();
            Application.Run(MainContext);
        }

        // Based on:
        // https://stackoverflow.com/a/32774750
        public static void ReplaceForm(Form MainForm, Form OldForm)
        {
            MainContext.MainForm = MainForm;
            MainContext.MainForm.Show();

            OldForm.Close();
        }
    }
}
