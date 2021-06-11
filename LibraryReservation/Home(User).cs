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
    public partial class frmUserHome : Form
    {
        public static Users user;
        public frmUserHome(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnRsrvRoom_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmReserveRoom(user), this);
        }

        private void btnChgRsrvRoom_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmEditCancleRoom(user), this);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmLogin(), this);
        }

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            //lblName.Text = $"Welcome back, {user.Name}";
            lblName.Text = $"{ user.Name }";
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
