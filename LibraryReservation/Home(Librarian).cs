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

        public frmLibrarianHome()
        {
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

        private void frmLibrarianHome_Load(object sender, EventArgs e)
        {

        }
    }
}
