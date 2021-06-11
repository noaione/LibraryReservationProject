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
            
            /*
            DatabaseBridge db = new DatabaseBridge();
            try
            {
                Rooms realRoom = db.FindUserByUsername(user);
            }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DatabaseBridge db = new DatabaseBridge();
            string place, time, duration;
            place = lstPlace.Text;
            time = dateTimePicker.Text;
            duration = lstDuration.Text;

            
            label1.Text = place + "\t" + time + "\t" + duration;
            
            
        }

        private void Reserve_Room_Load(object sender, EventArgs e)
        {
            DatabaseBridge db = new DatabaseBridge();
            DataTable roomsList = db.QueryDBAsTable("SELECT Name FROM Rooms");
            foreach (DataRow row in roomsList.Rows)
            {
                lstPlace.Items.Add(row["Name"]);
            }
            /*
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\APU\\Semester 2\\Introduce To Oriented Object Programming\\IOOP - Project\\LibraryReservation\\LibraryDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from Rooms", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lstPlace.Items.Add(dr.ToString());
            }
            con.Close();*/

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

        private void label1_Click(object sender, EventArgs e)
        { 
            
        }
    }
}
