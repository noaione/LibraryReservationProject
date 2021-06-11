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
    public partial class frmLibrarianHome : Form
    {
        public static Users user;
        public frmLibrarianHome(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new frmReports(user).Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void btnReq_Click(object sender, EventArgs e)
        {

        }
    }
}
