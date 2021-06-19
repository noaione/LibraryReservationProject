using System;
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
            Program.ReplaceForm(new frmReports(user), this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmLogin(), this);
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmSeeRequest(user), this);
        }
    }
}
