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
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\APU\Semester 2\Introduce To Oriented Object Programming\IOOP-Project\LibraryReservation\LibraryDatabase.mdf;Integrated Security = True");
        private static Users user;
        public frmEditCancleRoom(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectRoom;
            //UNTUK SEMENTARA
            if (lstRoom.SelectedItem == "")
            {
                MessageBox.Show("You Not Yet Select The Room");
                return;

            }
            else
            {
                // Program.ReplaceForm(new frmEditRoomReservation(user), this);
                //DataRowView sel = (DataRowView)lstRoom.SelectedItem;
                //string a = sel;
                selectRoom = lstRoom.SelectedItem.ToString();
                Program.ReplaceForm(new frmEditRoomReservation(user, selectRoom), this);
                
            }
            
            //BLM KELAR
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DataRowView sel = (DataRowView)lstRoom.SelectedItem;
            DatabaseBridge db = new DatabaseBridge();
            string reserveID = sel["ReserveID"].ToString();
            db.CommitToDB($"DELETE FROM Reservations WHERE ReserveID='{reserveID}'");
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
            ArrayList reservedArray = new ArrayList();
            foreach (DataRow room in roomList.Rows)
            {
                Rooms roomba = db.FindRoomByID(room["RoomID"].ToString(), true);
                int duration = int.Parse(room["Duration"].ToString());
                DateTime startRange = DateTime.Parse(room["DateTime"].ToString());
                Reservation r = new Reservation(room["ReserveID"].ToString(), user, roomba, startRange, duration);
                reservedArray.Add(r);
            }
            db.Close();
            lstRoom.DataSource = reservedArray;
            lstRoom.DisplayMember = "DisplayList";
            lstRoom.ValueMember = "ReserveID";

        }

        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
