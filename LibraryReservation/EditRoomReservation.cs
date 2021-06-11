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
    public partial class frmEditRoomReservation : Form
    {
        private static Users user;
        public frmEditRoomReservation(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void EditRoomReservation_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            new frmUserHome(user).Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create Database For Save Change
            MessageBox.Show("Record Saved !!");
            new frmUserHome(user).Show();
            this.Hide();
            //BLM KELAR
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmEditCancleRoom(user).Show();
            this.Hide();
        }
    }
}
