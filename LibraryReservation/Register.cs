using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
        
        // TODO: Add username verification yadayada.
        private void btnRegister_Click(object sender, EventArgs e)
            
        {
            txtInPassword.Focus();
            string username = txtInUsername.Text;
            string fullname = txtInPassword.Text;
            string password = txtInFullName.Text;
            string conpassword = txtInPasswordConf.Text;

            if (password.Length < MinimumPass && conpassword.Length < MinimumPass)
            {
                MessageBox.Show("Password length must be more than 6");
                return;
            }
            else
            {
                if(password != conpassword)
                {
                    MessageBox.Show("You Must Have Same Password And Confirm Password");
                    return;
                }
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
            } catch (UserNameAlreadyExist)
            {
                MessageBox.Show("Username already exist");
                txtInUsername.Clear();
                txtInUsername.Focus();
                return;
                
            } catch (UnknownDatabaseException)
            {
                MessageBox.Show("An unknown error occured, please try again later");
                return;
            }
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

        private void txtInFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtInPassword.Focus();
            string username = txtInUsername.Text;
            string fullname = txtInFullName.Text;
            string password = txtInPassword.Text;
            string conpassword = txtInPasswordConf.Text;

            if (password.Length < MinimumPass && conpassword.Length < MinimumPass)
            {
                MessageBox.Show("Password length must be more than 6");
                return;
            }
            else
            {
                if (password != conpassword)
                {
                    MessageBox.Show("You Must Have Same Password And Confirm Password");
                    return;
                }
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

        private void txtInUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInFullName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
