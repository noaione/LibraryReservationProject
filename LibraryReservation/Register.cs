using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibraryReservation

{
    public partial class frmRegister : Form
    {
        private const int MinimumPass = 6;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void lblLoginClick_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmLogin(), this);
        }

        /// <summary>
        /// Verify if the provided username is only Alphanumerical and no space included.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-z^A-Z^0-9]")) { 
                e.Handled = true;
            } else
            {
                e.Handled = false;
            }
        }
        
        private void BtnShowHide_Click(object sender, EventArgs e)
        {
            if (txtInPassword.PasswordChar == '*')
            {
                BtnShowHide.Image = Properties.Resources.PasswordHide;
                txtInPassword.PasswordChar = '\0';
                txtInPasswordConf.PasswordChar = '\0';
            }
            else
            {
                BtnShowHide.Image = Properties.Resources.PasswordVisible;
                txtInPassword.PasswordChar = '*';
                txtInPasswordConf.PasswordChar = '*';
            }
        }

        private bool IsPasswordGood(string password)
        {
            if (password.Length < MinimumPass)
            {
                MessageBox.Show("Password length must be more than or equal 6");
                return false;
            }
            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                MessageBox.Show("Password must include a single number");
                return false;
            }
            return true;
        }

        private bool CheckMinimumString(string content, int minimum = 0)
        {
            if (string.IsNullOrWhiteSpace(content) || string.IsNullOrEmpty(content))
            {
                return false;
            }

            if (content.Length < minimum)
            {
                return false;
            }
            return true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            txtInPassword.Focus();
            string username = txtInUsername.Text;
            string fullname = txtInFullName.Text;
            string password = txtInPassword.Text;
            string conpassword = txtInPasswordConf.Text;
            if (!CheckMinimumString(username, 3))
            {
                MessageBox.Show("Your username must be more or equal than 3 characters");
                return;
            }
            if (!CheckMinimumString(fullname, 1))
            {
                MessageBox.Show("Full name cannot be empty!");
                return;
            }
            if (!IsPasswordGood(password))
            {
                return;
            }

            if (password != conpassword)
            {
                MessageBox.Show("The password and your password confirmation is not the same!");
                return;
            }

            string hashPassword = PasswordManager.HashPassword(password);   
            DatabaseBridge db = new DatabaseBridge();
            try
            {
                Users user = new Users(fullname, username, hashPassword);
                user = db.CreateNewUser(user);
                if (user.Type == UserType.Librarian)
                {
                    Program.ReplaceForm(new frmLibrarianHome(user), this);
                }
                else
                {
                    Program.ReplaceForm(new frmUserHome(user), this);
                }
            }
            catch (UserNameAlreadyExist)
            {
                MessageBox.Show("Username already exist");
                txtInUsername.Clear();
                txtInUsername.Focus();
                return;

            }
            catch (UnknownDatabaseException)
            {
                MessageBox.Show("An unknown error occured, please try again later");
                return;
            }
        }
    }
}
