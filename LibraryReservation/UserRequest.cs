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
    public partial class frmSeeRequest : Form
    {
        public frmSeeRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Keep To Database, and tell User that his/her Request has been approve
            //Kalau Bisa Bkin yg MessageBox.Show yg pilih" itu
            //Yg Pilihannya
            //(Yes, Cancle)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmLibrarianHome().Show();
            this.Hide();
        }

        private object frmLibrarianHome()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete from Database, and tell User that his/her Request has been Rejected
        }

        private void frmSeeRequest_Load(object sender, EventArgs e)
        {

        }
    }
}
