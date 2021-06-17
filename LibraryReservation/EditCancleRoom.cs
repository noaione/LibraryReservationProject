using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //UNTUK SEMENTARA
            if (lstRoom.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a room first!");
                return;

            }
            else
            {
                // Program.ReplaceForm(new frmEditRoomReservation(user), this);
                //DataRowView sel = (DataRowView)lstRoom.SelectedItem;
                //string a = sel;
                DatabaseBridge db = new DatabaseBridge();
                Reservation sel = (Reservation)lstRoom.SelectedItem;

                int alreadyRequested = db.CountTable("ReservationChanges", $"WHERE ReserveID = '{sel.ReserveID}' AND ApprovedFlag = 0");
                if (alreadyRequested > 0)
                {
                    MessageBox.Show("You've already requested a change for this Reservation!");
                    return;
                }
                Program.ReplaceForm(new frmEditRoomReservation(user, sel), this);
                
            }
            
            //BLM KELAR
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
            /*
            string room;
            room = lstRoom.SelectedItem.ToString();
            DatabaseBridge db = new DatabaseBridge();
            db.CommitToDB("DELETE FROM Reservations WHERE RoomID = '" + room + "'");
            MessageBox.Show("The Room Have Been Cancled"); // DELETE FROM DB
            Program.ReplaceForm(new frmUserHome(user), this);
            //BLM KELAR*/
        }

        private void frmEditCancleRoom_Load(object sender, EventArgs e)
        {
            DatabaseBridge db = new DatabaseBridge();
            // Source: https://stackoverflow.com/a/17418301
            DateTime now = DateTime.Now;
            string SQLFormattedNow = now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            DataTable roomList = db.QueryDBAsTable($"SELECT * FROM Reservations WHERE UserID = '{user.UserID}'", true);
            // Mungkin ganti ke class Reservations, terus buat get custom biar keliatannya enak.
            List<Reservation> reservedArray = new List<Reservation>();
            foreach (DataRow room in roomList.Rows)
            {
                Rooms roomba = db.FindRoomByID(room["RoomID"].ToString(), true);
                int duration = int.Parse(room["Duration"].ToString());
                DateTime startRange = DateTime.Parse(room["DateTime"].ToString()).ToUniversalTime();
                Reservation r = new Reservation(room["ReserveID"].ToString(), user, roomba, startRange, duration);
                reservedArray.Add(r);
            }
            db.Close();
            // Sort by time
            reservedArray.Sort((x, y) => x.DateTime.CompareTo(y.DateTime));
            lstRoom.DataSource = reservedArray;
            lstRoom.DisplayMember = "DisplayList";
            lstRoom.ValueMember = "ReserveID";

        }
    }
}
