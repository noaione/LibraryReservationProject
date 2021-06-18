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
        private static Reservation reservation;
        private static ReservationChange reservechange;
        public frmEditRoomReservation(Users u, Reservation r)
        {
            InitializeComponent();
            user = u;
            reservation = r;
            reservechange = new ReservationChange(r);
        }

        private void EditRoomReservation_Load(object sender, EventArgs e)
        {
            lblReserveInfoText.Text = $"Room: {reservation.Room.Name}\nLocation: {reservation.Room.Location}\nCapacity: {reservation.Room.Capacity}\nTime: {reservation.DateTimeText} MYT\nDuration: {reservation.Duration} Minutes";
            // Custom datepicker formatting
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "ddd, dd MMM yyyy HH:mm";
            // Set minimum to current time :TM:
            dateTimePicker.MinDate = DateTime.Now;
            DatabaseBridge databaseBridge = new DatabaseBridge();
            DatabaseBridge db = databaseBridge;
            DataTable roomsList = db.QueryDBAsTable("SELECT * FROM Rooms");
            lstNewRoom.DataSource = roomsList;
            lstNewRoom.DisplayMember = "Name";
            lstNewRoom.ValueMember = "RoomID";
            lstDuration.SelectedIndex = 0;
            lstNewRoom.SelectedIndex = 0;
            ChangeNewReserveBox();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmEditCancleRoom(user), this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Reservation newReservation = reservechange.NewReservation;

            DatabaseBridge db = new DatabaseBridge();
            Reservation conflicted = db.ReservationConflictCheck(newReservation);
            if (conflicted != null)
            {
                MessageBox.Show("Sorry, there's already someone else booking at that time.");
                return;
            }
            // Add to reservation changes table:
            string ValueSets = $"('{reservechange.ChangeID}', '{newReservation.ReserveID}', '{reservation.RoomID}', '{newReservation.RoomID}', '{reservation.DateTimeSQL}', '{newReservation.DateTimeSQL}', {reservation.Duration}, {newReservation.Duration}, '{reservechange.Timestamp:s}', '{reservechange.Reason}', 0)";
            //db.CommitToDB($"UPDATE Reservations SET DateTime = '{reservation.DateTimeSQL}', Duration = {reservation.Duration} WHERE ReserveID = '{reservation.ReserveID}'");
            db.CommitToDB($"INSERT INTO ReservationChanges VALUES {ValueSets}");
            MessageBox.Show("Change requested, please check again later!");
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void ChangeNewReserveBox()
        {
            Rooms room = reservechange.NewRoom;
            DateTime dt = reservechange.NewDate;
            string roomData = "Room: Not selected\nLocation: Unknown\nCapacity: Unknown";
            string newBookTime = "Time: Not selected";
            string newDuration = $"Duration: {reservechange.NewDuration} Minutes";
            if (room != null)
            {
                roomData = $"Room: {room.Name}\nLocation: {room.Location}\nCapacity: {room.Capacity}";
            }
            if (dt != null)
            {
                newBookTime = "Time: " + dt.AddHours(8).ToString("ddd, dd MMM yyyy HH:mm") + " MYT";
            }
            lblNewRInfoText.Text = $"{roomData}\n{newBookTime}\n{newDuration}";
        }

        private void lstNewRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView sel = (DataRowView)lstNewRoom.SelectedItem;
            Rooms reserveRoom = new Rooms(sel["RoomID"].ToString(), sel["Name"].ToString(), int.Parse(sel["Capacity"].ToString()), sel["Location"].ToString());
            reservechange.NewRoom = reserveRoom;
            ChangeNewReserveBox();
        }

        private void lstDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            int duration = int.Parse(lstDuration.SelectedItem.ToString().Replace(" Minutes", ""));
            reservechange.NewDuration = duration;
            ChangeNewReserveBox();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime time = dateTimePicker.Value.ToUniversalTime();
            reservechange.NewDate = time;
            ChangeNewReserveBox();
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            reservechange.Reason = txtReason.Text;
        }
    }
}
