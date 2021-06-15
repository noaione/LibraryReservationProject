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
    
    public partial class frmEditRoomReservation : Form
    {
        private static Users user;
        private static Rooms room;
        private string selectRoom;

        public frmEditRoomReservation(Users u,string selectRoom)
        {
            InitializeComponent();
            user = u;
        }

        private void EditRoomReservation_Load(object sender, EventArgs e)
        {
            lblRoomName.Text = selectRoom + "";
            lblRoomName.Text = selectRoom;
            lblRoomName.Text = $"{selectRoom}";
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create Database For Save Change
            DatabaseBridge db = new DatabaseBridge();
            MessageBox.Show("Record Saved !!");
            Program.ReplaceForm(new frmUserHome(user), this);
            //BLM KELAR
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmEditCancleRoom(user), this);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
