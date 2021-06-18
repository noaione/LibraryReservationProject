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
        private static Users user;
        private List<ReservationChange> reservationChanges = new List<ReservationChange>();

        public frmSeeRequest(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private string FormatReservation(Reservation rr)
        {
            return $"Room: {rr.Room.Name}\nTime: {rr.DateTimeText}\nDuration: {rr.Duration} minutes";
        }

        private void frmSeeRequest_Load(object sender, EventArgs e)
        {
            DatabaseBridge db = new DatabaseBridge();
            DataTable table = db.QueryDBAsTable("SELECT RC.*, R.UserID FROM ReservationChanges AS RC INNER JOIN Reservations AS R ON R.ReserveID = RC.ReserveID WHERE RC.ApprovedFlag = 0", true);

            Dictionary<string, Rooms> savedRooms = new Dictionary<string, Rooms>();
            foreach (DataRow row in table.Rows)
            {
                string newRoomID = row["NewRoom"].ToString();
                Rooms newRoom;
                if (savedRooms.ContainsKey(newRoomID))
                {
                    newRoom = savedRooms[newRoomID];
                }
                else
                {
                    newRoom = db.FindRoomByID(newRoomID, true);
                }

                Reservation oldReserve = db.FindReservationByID(row["ReserveID"].ToString());
                int duration = int.Parse(row["DurationAfter"].ToString());
                DateTime startRange = DateTimeOffset.Parse(row["DateAfter"].ToString() + "+00").UtcDateTime;
                DateTime timestamp = DateTimeOffset.Parse(row["Timestamp"].ToString() + "+00").UtcDateTime;
                string reason = row["Reason"].ToString();
                int flag = int.Parse(row["ApprovedFlag"].ToString());

                ReservationChange change = new ReservationChange(row["ChangesID"].ToString(), oldReserve, newRoom, startRange, duration, timestamp, reason, flag);
                reservationChanges.Add(change);
            }

            db.Close();
            reservationChanges.Sort((x, y) => x.Timestamp.CompareTo(y.Timestamp));
            lstRequest.DataSource = reservationChanges;
            lstRequest.DisplayMember = "DisplayData";
            lstRequest.ValueMember = "ChangeID";
            if (reservationChanges.Count < 1)
            {
                lblRequester.Text = "Requester: None";
                lblOldInfoText.Text = "Please select a request first";
                lblNewInfoText.Text = "Please select a request first";
            }
            else
            {
                lblRequester.Text = $"Requester: {reservationChanges[0].OldReservation.User.Name}";
                lblOldInfoText.Text = FormatReservation(reservationChanges[0].OldReservation);
                lblNewInfoText.Text = FormatReservation(reservationChanges[0].NewReservation);
                txtReasonBox.Text = reservationChanges[0].Reason;
                lstRequest.SelectedIndex = 0;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Approve

            ReservationChange change = (ReservationChange)lstRequest.SelectedItem;
            if (lstRequest.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Request First !!");
                return;
            }
            else
            {
                int acceptPos = lstRequest.SelectedIndex;
                int removePos = lstRequest.SelectedIndex;

                DatabaseBridge db = new DatabaseBridge();
                Reservation reservation = db.FindReservationByID("");
                DataTable table = db.QueryDBAsTable("SELECT RC.*, R.UserID FROM ReservationChanges AS RC INNER JOIN Reservations AS R ON R.ReserveID = RC.ReserveID WHERE RC.ApprovedFlag = 0", true);
                Dictionary<string, Rooms> savedRooms = new Dictionary<string, Rooms>();

                foreach (DataRow row in table.Rows)
                {
                    string newRoomID = row["NewRoom"].ToString();
                    Rooms newRoom;
                    if (savedRooms.ContainsKey(newRoomID))
                    {
                        newRoom = savedRooms[newRoomID];
                    }
                    else
                    {
                        newRoom = db.FindRoomByID(newRoomID, true);
                    }

                    Reservation oldReserve = db.FindReservationByID(row["ReserveID"].ToString());
                    int duration = int.Parse(row["DurationAfter"].ToString());
                    DateTime startRange = DateTimeOffset.Parse(row["DateAfter"].ToString() + "+00").UtcDateTime;
                    int flag = int.Parse(row["ApprovedFlag"].ToString());

                    //ReservationChange setchange = new ReservationChange(row["ChangesID"].ToString(), oldReserve, newRoom, startRange, duration, flag);
                    //reservationChanges.Add(setchange);
                    db.CommitToDB("UPDATE Reservations SET DateTime = '" + startRange + "', Duration = '" + duration + "' WHERE ReserveID = '" + oldReserve + "'");
                    db.CommitToDB($"UPDATE ReservationChanges SET ApprovedFlag = 1 WHERE ChangesID='{change.ChangeID}'");

                }

            }

            // SQL Template:
            // $"UPDATE Reservations SET DateTime = '{reservation.DateTimeSQL}', Duration = {reservation.Duration} WHERE ReserveID = '{reservation.ReserveID}'"
            // $"UPDATE ReservationChanges SET ApprovedFlag = 1 WHERE ChangesID='{change.ChangeID}'"

            // Update the main reservations data
            // After that update the changes data to approved.
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            // Reject
            ReservationChange change = (ReservationChange)lstRequest.SelectedItem;
            if (lstRequest.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Request First !!");
                return;
            }
            else
            {
                int removePos = lstRequest.SelectedIndex;
                DatabaseBridge db = new DatabaseBridge();
                db.CommitToDB($"UPDATE ReservationChanges SET ApprovedFlag = -1 WHERE ChangesID='{change.ChangeID}'");
                lstRequest.SelectedIndex = 0;
                lstRequest.DataSource = null;
                reservationChanges.RemoveAt(removePos);
                lstRequest.DataSource = reservationChanges;
                lstRequest.DisplayMember = "DisplayData";
                lstRequest.ValueMember = "ChangeID";
                MessageBox.Show($"Request {change.ChangeID} has been rejected!");
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmLibrarianHome(user), this);
        }

        private void lstRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReservationChange change = (ReservationChange)lstRequest.SelectedItem;
            if (change == null || reservationChanges == null)
            {
                // Ignore when everything is still froze.
                return;
            }
            lblRequester.Text = $"Requester: {change.OldReservation.User.Name}";
            lblOldInfoText.Text = FormatReservation(change.OldReservation);
            lblNewInfoText.Text = FormatReservation(change.NewReservation);
            txtReasonBox.Text = change.Reason;
        }
    }
}
