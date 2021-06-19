using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryReservation
{
    public partial class frmReports : Form
    {
        public static Users user;
        private List<Rooms> allRooms;
        private List<Reservation> allReservations;
        public frmReports(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmLibrarianHome(user), this);
        }

        /// <summary>
        /// Check if the time is today. Will be checked in UTC
        /// </summary>
        /// <param name="time">The time to be checked on</param>
        /// <returns>Is the provided time is today</returns>
        private bool IsToday(DateTime time)
        {
            // Convert to MYT
            DateTime MYTTime = time.ToUniversalTime().AddHours(8);
            DateTime today = DateTime.UtcNow.AddHours(8);
            return MYTTime.Year == today.Year && MYTTime.Month == today.Month && MYTTime.Day == today.Day;
        }

        private void ReportDailyReadjust(Rooms selRoom)
        {
            if (selRoom == null || allReservations == null)
            {
                lblDTotal.Text = "Total reservation: 0";
                lblDTotalHours.Text = "Total Reserved Hours: 0 hour";
                lblDAvgTime.Text = "Average Reserved Time: 0 Hour";
                return;
            }
            List<Reservation> reservations = allReservations.FindAll(room => room.RoomID == selRoom.RoomID && IsToday(room.DateTime));
            if (reservations.Count < 1)
            {
                lblDTotal.Text = "Total reservation: 0";
                lblDTotalHours.Text = "Total Reserved Hours: 0 hour";
                lblDAvgTime.Text = "Average Reserved Time: 0 hour";
            }
            else
            {
                lblDTotal.Text = $"Total reservation: {reservations.Count}";
                int totalMinutes = 0;
                int totalItem = 0;
                foreach (Reservation reservation in reservations)
                {
                    totalMinutes += reservation.Duration;
                    totalItem += 1;
                }
                int totalHours = 0;
                if (totalMinutes > 0)
                {
                    totalHours = totalMinutes / 60;
                }
                int average = 0;
                if (totalHours > 0)
                {
                    average = totalHours / totalItem;
                }
                lblDTotalHours.Text = $"Total Reserved Hours: {totalHours} hours";
                lblDAvgTime.Text = $"Average Reserved Time: {average} hours";
            }
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            DateTime MYTTime = DateTime.UtcNow.AddHours(8);
            DatabaseBridge databaseBridge = new DatabaseBridge();
            DatabaseBridge db = databaseBridge;
            DataTable roomsList = db.QueryDBAsTable("SELECT * FROM Rooms", true);
            List<Rooms> roomsArray = new List<Rooms>();
            foreach (DataRow room in roomsList.Rows)
            {
                int amountFit = int.Parse(room["Capacity"].ToString());
                Rooms roomba = new Rooms(room["RoomID"].ToString(), room["Name"].ToString(), amountFit, room["Location"].ToString());
                roomsArray.Add(roomba);
            }
            allRooms = roomsArray;
            lstRoom.DataSource = roomsArray;
            lstRoom.DisplayMember = "Name";
            lstRoom.ValueMember = "RoomID";

            DataTable reservations = db.QueryDBAsTable($"SELECT * FROM Reservations");

            List<Reservation> reservedArrays = new List<Reservation>();
            foreach (DataRow row in reservations.Rows)
            {
                Rooms roomba = roomsArray.Find((room) => room.RoomID == row["RoomID"].ToString());
                int duration = int.Parse(row["Duration"].ToString());
                DateTime startRange = DateTimeOffset.Parse(row["DateTime"].ToString() + "+00").UtcDateTime;
                Reservation r = new Reservation(row["ReserveID"].ToString(), user, roomba, startRange, duration);
                reservedArrays.Add(r);
            }
            allReservations = reservedArrays;

            DateTime currentDt = DateTime.UtcNow;
            DateTime startOfAMonth = new DateTime(currentDt.Year, currentDt.Month, 1);
            List<Reservation> currentMonthReservations = reservedArrays.FindAll(res => res.DateTime >= startOfAMonth);
            int totalMinutes = 0;
            int totalItem = 0;
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            foreach (Reservation reservation in currentMonthReservations)
            {
                totalMinutes += reservation.Duration;
                totalItem += 1;
                if (!occurences.ContainsKey(reservation.Room.Name))
                {
                    occurences.Add(reservation.Room.Name, 1);
                }
                else
                {
                    occurences[reservation.Room.Name] += 1;
                }
            }

            int totalHours = 0;
            if (totalMinutes > 0)
            {
                totalHours = totalMinutes / 60;
            }
            int average = 0;
            if (totalHours > 0)
            {
                average = totalHours / totalItem;
            }

            lblTotalHours.Text = $"Total Hours Reserved: {totalHours} hours";
            lblMAvgHours.Text = $"Average Reserved Time: {average} hours";
            if (occurences.Count < 1)
            {
                lblMUsed.Text = "Most Used Room: None";
                lblLUsed.Text = "Least Used Room: None";
            }
            else
            {
                // https://stackoverflow.com/a/2806074
                string mostUsed = occurences.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                // https://stackoverflow.com/a/23734742
                string leastUsed = occurences.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
                lblMUsed.Text = $"Most Used Room: {mostUsed}";
                lblLUsed.Text = $"Least Used Room: {leastUsed}";
            }
            lstRoom.SelectedIndex = 0;
            if (allRooms.Count > 0)
            {
                Rooms firstRoom = allRooms[0];
                ReportDailyReadjust(firstRoom);
            }
            else
            {
                ReportDailyReadjust(null);
            }
            lblDailyTitle.Text = $"Daily Report ({MYTTime:dd MMM yyyy})";
        }

        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rooms selRoom = (Rooms)lstRoom.SelectedItem;
            ReportDailyReadjust(selRoom);
        }
    }
}
