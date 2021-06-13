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

        private void lstPlace_SelectedIndexChange(object sender, EventArgs e)
        {
            DataRowView sel = (DataRowView)lstPlace.SelectedItem;
            string roomId = sel["RoomID"].ToString();
            string roomName = sel["Name"].ToString();
            string roomLocation = sel["Location"].ToString();
            string capacity = sel["Capacity"].ToString();

            lblRoomID.Text = $"Debug:\nID: {roomId}\nName: {roomName}\nLocation: {roomLocation}\nCapacity: {capacity}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string place,time,duration;
            place = lstPlace.Text;
            time = dateTimePicker.Text;
            duration = lstDuration.Text;
            
            DatabaseBridge db = new DatabaseBridge();
            //BAWAH MASIH SALAH MAU DI ROMBAK
            //Reservation reservation = new Reservation(place, time, duration);


            //label1.Text = place + "\t" + time + "\t" + duration;


        }

        private void Reserve_Room_Load(object sender, EventArgs e)
        {
            //DatabaseBridge db = new DatabaseBridge();
            //DataTable roomsList = db.QueryDBAsTable("SELECT Name FROM Rooms");
            //foreach (DataRow row in roomsList.Rows)
            //{
            //    lstPlace.Items.Add(row["Name"]);
            //}
            
            DatabaseBridge databaseBridge = new DatabaseBridge();
            DatabaseBridge db = databaseBridge;
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
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void label1_Click(object sender, EventArgs e)
        { 
            
        }
    }
}
