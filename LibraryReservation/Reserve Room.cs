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

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (lstPlace.SelectedItem == null && lstDuration.SelectedItem == null)
            {
                MessageBox.Show("Please Select Place And Duration !!");
                return;
            }
            else if (lstPlace.SelectedItem == null)
            {
                MessageBox.Show("Please Select Your Place !!");
                return;
            }
            else if (lstDuration.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Duration !!");
                return;
            }
            else
            {
                DateTime time = dateTimePicker.Value.ToUniversalTime();
                int duration = int.Parse(lstDuration.SelectedItem.ToString().Replace(" Minutes", ""));

                DatabaseBridge db = new DatabaseBridge();
                DataRowView sel = (DataRowView)lstPlace.SelectedItem;
                string reserverid = "RR" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
                Rooms reserveRoom = new Rooms(sel["RoomID"].ToString(), sel["Name"].ToString(), int.Parse(sel["Capacity"].ToString()), sel["Location"].ToString());
                Reservation reserve = new Reservation(reserverid, user, reserveRoom, time, duration);

                Reservation anyRoom = db.ReservationConflictCheck(reserve);
                if (anyRoom != null)
                {
                    MessageBox.Show("Sorry, there's already someone else booking at that time.");
                    // Show extra info
                    return;
                }
                db.CommitToDB($"INSERT INTO Reservations values ('{reserve.ReserveID}', '{reserve.UserID}', '{reserve.RoomID}', '{reserve.DateTimeSQL}', '{reserve.Duration}')");

                MessageBox.Show("Your room is now reserved!");
                Program.ReplaceForm(new frmUserHome(user), this);
            }
            
        }

        private void Reserve_Room_Load(object sender, EventArgs e)
        {
            // Custom datepicker formatting
            dateTimePicker.MinDate = DateTime.Now;
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "ddd, dd MMM yyyy HH:mm";

            DatabaseBridge databaseBridge = new DatabaseBridge();
            DatabaseBridge db = databaseBridge;
            DataTable roomsList = db.QueryDBAsTable("SELECT * FROM Rooms");
            lstPlace.DataSource = roomsList;
            lstPlace.DisplayMember = "Name";
            lstPlace.ValueMember = "RoomID";
           
        }

        private void lstDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataRowView sel = (DataRowView)lstDuration.SelectedItem;
            string sel = lstDuration.SelectedItem.ToString();
            string duration = sel.ToString();
            lblMinutes.Text = "Duration :" + duration;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void label1_Click(object sender, EventArgs e)
        { 
            
        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }
    }
}
