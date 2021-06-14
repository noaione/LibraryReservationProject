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
    public partial class frmReports : Form
    {
        public static Users user;
        public frmReports(Users u)
        {
            InitializeComponent();
            user = u;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmLibrarianHome(user), this);
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            DatabaseBridge databaseBridge = new DatabaseBridge();
            DatabaseBridge db = databaseBridge;
            DataTable roomsList = db.QueryDBAsTable("SELECT * FROM Rooms");
            lstRoom.DataSource = roomsList;
            lstRoom.DisplayMember = "Name";
            lstRoom.ValueMember = "RoomID";
        }

        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            DataRowView sel = (DataRowView)lstRoom.SelectedItem;
            DatabaseBridge databasebridge = new DatabaseBridge();
            DatabaseBridge db = databasebridge;
            DataTable reservationList = db.QueryDBAsTable($"SELECT ReserveID FROM Reservations WHERE RoomID = '{sel}'");
            string roomId = sel["RoomID"].ToString();
            string roomName = sel["Capacity"].ToString();

            lblDTotal.Text = $"Debug:\nID: {roomId}\nName: {roomName}";*/
            //Belum Yg Bawah List(Daily Repoty) & Monthly Report
        }
    }
}
