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
    public partial class frmReserveRoom : Form
    {
        private static Users user;
        public frmReserveRoom(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Take Available Room from Database
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseBridge db = new DatabaseBridge();
            DataTable tabel = db.QueryDBAsTable("SELECT * FROM Rooms");
            /*HARUS TERPILIH SEMUA DULU BARU DI SAVE
            Save All Record From User To Database
            MessageBox.Show("Record Saved !!");
            new frmUserHome(user).Show();
            this.Hide();
            BLM KELAR*/
        }

        private void Reserve_Room_Load(object sender, EventArgs e)
        {

        }

        private void lstDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Save User Input To Database
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmUserHome(user).Show();
            this.Hide();
        }
    }
}
