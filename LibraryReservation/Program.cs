using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryReservation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            new Reserve_Room().Show();
            Application.Run();
=======
            Application.Run(new LoginForm());
>>>>>>> ee2edf8e53a01f2067e28865d37a335de8edaf37
        }
    }
}
