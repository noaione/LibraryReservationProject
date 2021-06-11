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
            string place, time, duration;
            place = lstPlace.Text;
            time = dateTimePicker.Text;
            duration = lstDuration.Text;

            
            if(place == "")
            {
                MessageBox.Show("Please Select Your Place !!");
                return;
            }
            else if(duration == "")
            {
                MessageBox.Show("Please Select Your Duration !!");
                return;
            }
            else if (place == "" || duration == "")
            {
                MessageBox.Show("Please Select Your Place and Duration !!");
                return;
            }
            else
            {
                //Save To Database
            }
            
            
            
            
        }

        private void Reserve_Room_Load(object sender, EventArgs e)
        {
            DatabaseBridge db = new DatabaseBridge();
            DataTable roomsList = db.QueryDBAsTable("SELECT Name FROM Rooms");
            foreach (DataRow row in roomsList.Rows)
            {
                lstPlace.Items.Add(row["Name"]);
            }

            DatabaseBridge db = new DatabaseBridge();
            DataTable roomsList = db.QueryDBAsTable("SELECT * FROM Rooms");
            lstPlace.DataSource = roomsList;
            lstPlace.DisplayMember = "Name";
            lstPlace.ValueMember = "RoomID";
           
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
