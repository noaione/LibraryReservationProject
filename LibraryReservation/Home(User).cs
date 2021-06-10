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
    public partial class frmUserHome : Form
    {
        public frmUserHome()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRsrvRoom_Click(object sender, EventArgs e)
        {
            new frmReserveRoom().Show();
            this.Hide();
        }

        private void btnChgRsrvRoom_Click(object sender, EventArgs e)
        {
            new frmEditCancleRoom().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
