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
            new frmReserveRoom(user).Show();
            this.Hide();
        }

        private void btnChgRsrvRoom_Click(object sender, EventArgs e)
        {
            new frmEditCancleRoom(user).Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void frmUserHome_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string fullname;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\APU\\Semester 2\\Introduce To Oriented Object Programming\\IOOP - Project\\LibraryReservation\\LibraryDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Fullname from Users where  = '" + user);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fullname = dr.GetValue(0).ToString();
            }
        }
    }
}
