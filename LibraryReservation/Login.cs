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
            if (username == "admin" && password == "admin")
            {
                new frmLibrarianHome().Show();
                this.Hide();
                MessageBox.Show("Hi, Admin");
            }
            else
            {
                //MATCH INPUT OF USERNAME AND PASSWORD TO DATABASE
                //IF INPUT == TRUE ==> GO TO frmUserHome
                //IF INPUT == FALSE ==> ASK USER TO INPUT AGAIN
                new frmUserHome().Show();
                this.Hide();//UNTUK SEMENTARA AJA DULU NNTI DIPASANGIN IF ELSE KE DB

            }
        }
    }
}
