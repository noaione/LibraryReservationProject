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
                        MessageBox.Show($"Welcome Back, {realUser.Name}");
                        new frmLibrarianHome(realUser).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Welcome Back, {realUser.Name}");
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


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            if (txtInPassword.PasswordChar == '*')
            {
                BtnShowHide.Image = Properties.Resources.PasswordHide;
                txtInPassword.PasswordChar = '\0';
            }
            else
            {
                BtnShowHide.Image = Properties.Resources.PasswordVisible;
                txtInPassword.PasswordChar = '*';
            }
        }
    }
}
