﻿using System;
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
            new frmLogin().Show();
            this.Hide();
        }

        // TODO: Add username verification yadayada.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtInUsername.Text;
            string fullname = txtInFullName.Text;
            string password = txtInPassword.Text;

            if (password.Length < MinimumPass)
            {
                MessageBox.Show("Password length must be more than 6");
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
                    new frmLibrarianHome().Show();
                    this.Hide();
                }
                else
                {
                    new frmUserHome().Show();
                    this.Hide();
                }
            } catch (UserNameAlreadyExist)
            {
                MessageBox.Show("Username already exist");
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
    }
}
