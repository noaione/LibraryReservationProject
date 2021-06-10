using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryReservation
{
    class Secrets
    {
        public string SQLStringConnection;
        // Will be used to act as password hash
        // DO NOT CHANGES
        // WILL BREAK PASSWORD VERIFICATION
        public string PassEntropy = "aa4467e123c860e3";
        public Secrets()
        {
            // Ubah ke tempat file LibraryDB.mdf situ
            // Kalo misalkan ada backslash (\) itu buat dua kali, jadi dari ini:
            // T:\APU\Class Project\IOOP\IOOP-Project\LibraryReservation\LibraryDB.mdf
            // ke:
            // T:\\APU\\Class Project\\IOOP\\IOOP-Project\\LibraryReservation\\LibraryDB.mdf
            // Harus begitu, atau enggak error.
            string DBFilePath = "T:\\APU\\Class Project\\IOOP\\IOOP-Project\\LibraryReservation\\LibraryDB.mdf";
            SQLStringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + DBFilePath + ";Integrated Security=True";
        }


    }
}
