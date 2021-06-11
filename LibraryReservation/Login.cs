using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                        new frmLibrarianHome(realUser).Show();
                        this.Hide();
                    }
                    else
                    {
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
    }
}
