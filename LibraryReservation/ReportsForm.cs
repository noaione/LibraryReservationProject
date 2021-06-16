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

            DataTable reservations = db.QueryDBAsTable($"SELECT RoomID FROM Reservations");
         
        }
        SqlConnection con;
        //  int count = 0;
        int totalReserve ,count = 0; string reserve = "";
        double Durationcalc = 0; 
        private void lstRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            reserve = ""; 
            totalReserve = count = 0;
            Durationcalc = 0;
            DataRowView sel = (DataRowView)lstRoom.SelectedItem;
            DatabaseBridge databasebridge = new DatabaseBridge();
            DatabaseBridge db = databasebridge;
            DataTable reservationList = db.QueryDBAsTable($"SELECT ReserveID FROM Reservations WHERE RoomID = '{sel}'");
            string roomname = sel["RoomID"].ToString();
            string capacity = sel["Capacity"].ToString();

            using (SqlDataReader dr = DataManager.GetDataReader("GetRoomData", out con,
                 new SqlParameter("@RoomID", roomname)))
            {
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                         if (Convert.ToDateTime(dr["DateTime"].ToString().Substring(0, 10))
                            == Convert.ToDateTime(DateTime.Now.ToShortDateString()))
                        {
                            totalReserve++;
                            Durationcalc += double.Parse(dr["Duration"].ToString());
                            count++;
                        }
                    }

                }
            }
            con.Close();
            reserve = totalReserve.ToString();
            lblDTotal.Text = $"Room Name: {roomname}\nCapacity:{capacity}\nTotal Reserved:{reserve}";
            lblDAvgTime.Text = "Average Reserved Time: " + ((Durationcalc/60) / count) + " hours";
        }
        
        private void lblDTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDAvgTime_Click(object sender, EventArgs e)
        {
           
        }

        private void lblMUsed_Click(object sender, EventArgs e)
        {
            //most used room
        }

        private void lblLUsed_Click(object sender, EventArgs e)
        {
            //least used room
        }

        private void lblTotalHours_Click(object sender, EventArgs e)
        {
            //total hours booked
        }

        private void lblMAvgHours_Click(object sender, EventArgs e)
        {
            //avergae reserved time09
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
    
        }
    }
}
