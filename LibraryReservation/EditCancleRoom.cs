using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryReservation
{
    public partial class frmEditCancleRoom : Form
    {
        private static Users user;

        public frmEditCancleRoom(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Reservation sel = (Reservation)lstRoom.SelectedItem;
            if (sel == null)
            {
                MessageBox.Show("Please select a room first!");
                return;
            }
            DatabaseBridge db = new DatabaseBridge();

            int alreadyRequested = db.CountTable("ReservationChanges", $"WHERE ReserveID = '{sel.ReserveID}' AND ApprovedFlag = 0");
            if (alreadyRequested > 0)
            {
                MessageBox.Show("You've already requested a change for this Reservation!");
                return;
            }
            Program.ReplaceForm(new frmEditRoomReservation(user, sel), this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Reservation sel = (Reservation)lstRoom.SelectedItem;
            DatabaseBridge db = new DatabaseBridge();
            // First dereference the ReservationChanges.
            db.CommitToDB($"DELETE From ReservationChanges WHERE ReserveID='{sel.ReserveID}'");
            // After that dereference the reservation.
            db.CommitToDB($"DELETE FROM Reservations WHERE ReserveID='{sel.ReserveID}'");
            MessageBox.Show("Record Delete Successfully");
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void frmEditCancleRoom_Load(object sender, EventArgs e)
        {
            DatabaseBridge db = new DatabaseBridge();
            // People cannot change reservation 5 minutes before the reservation start!
            DateTime gracePeriod5min = DateTime.UtcNow.Subtract(new TimeSpan(0, -5, 0));
            DataTable roomList = db.QueryDBAsTable($"SELECT * FROM Reservations WHERE UserID = '{user.UserID}' AND DateTime > '{gracePeriod5min:s}'", true);
            List<Reservation> reservedArray = new List<Reservation>();
            foreach (DataRow room in roomList.Rows)
            {
                Rooms roomba = db.FindRoomByID(room["RoomID"].ToString(), true);
                int duration = int.Parse(room["Duration"].ToString());
                DateTime startRange = DateTimeOffset.Parse(room["DateTime"].ToString() + "+00").UtcDateTime;
                Reservation r = new Reservation(room["ReserveID"].ToString(), user, roomba, startRange, duration);
                reservedArray.Add(r);
            }
            db.Close();
            // Sort by time
            reservedArray.Sort((x, y) => x.DateTime.CompareTo(y.DateTime));
            lstRoom.DataSource = reservedArray;
            lstRoom.DisplayMember = "DisplayList";
            lstRoom.ValueMember = "ReserveID";
            lstRoom.SelectedIndex = 0;
        }
    }
}