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
            user = u;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            DataRowView sel = (DataRowView)lstPlace.SelectedItem;
            DateTime time = dateTimePicker.Value.ToUniversalTime();
            string durationText = (string)lstDuration.SelectedItem;
            if (sel == null)
            {
                MessageBox.Show("Please select a place first!");
            }
            if (durationText == null)
            {
                MessageBox.Show("Please select a duration first!");
            }

            int duration = int.Parse(durationText.Replace(" Minutes", ""));

            DatabaseBridge db = new DatabaseBridge();
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
            lstDuration.SelectedIndex = 0;
            lstPlace.SelectedIndex = 0;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmUserHome(user), this);
        }
    }
}
