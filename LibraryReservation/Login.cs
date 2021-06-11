using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryReservation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblRegisterClick_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fullname;
            string username = txtInUsername.Text;
            string password = txtInPassword.Text;

            DatabaseBridge db = new DatabaseBridge();
            
            try
            {
                Users realUser = db.FindUserByUsername(username);
                if (PasswordManager.Verify(password, realUser.HashedPassword))
                {
                    if (realUser.Type == UserType.Librarian)
                    {
                        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\APU\\Semester 2\\Introduce To Oriented Object Programming\\IOOP-Project\\LibraryReservation\\LibraryDatabase.mdf; Integrated Security = True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select Fullname from Users where username ='" + username + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            fullname = dr.GetValue(0).ToString();
                            MessageBox.Show("Welcome Back, " + fullname);
                        }
                        con.Close();
                        new frmLibrarianHome(realUser).Show();
                        this.Hide();
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\APU\\Semester 2\\Introduce To Oriented Object Programming\\IOOP-Project\\LibraryReservation\\LibraryDatabase.mdf; Integrated Security = True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Select Fullname from Users where username ='" + username + "'", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            fullname = dr.GetValue(0).ToString();
                            MessageBox.Show("Welcome Back, " + fullname);
                        }
                        con.Close();
                        new frmUserHome(realUser).Show();
                        this.Hide();
                    }
                } else
                {
                    MessageBox.Show("Invalid username and password combination");
                }
            } catch (UserNotFoundException)
            {
                MessageBox.Show("Cannot find that username");
            }
        }

        private void txtInPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtInPassword.PasswordChar == '*')
            {
                txtInPassword.PasswordChar = '\0';
            }
            else
            {
                txtInPassword.PasswordChar = '*';
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
