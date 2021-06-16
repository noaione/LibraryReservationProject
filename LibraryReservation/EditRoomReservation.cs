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
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\APU\\Semester 2\\Introduce To Oriented Object Programming\\IOOP - Project\\LibraryReservation\\LibraryDatabase.mdf;Integrated Security=True");

        private static Users user;
        private static Reservation reservation;
        public frmEditRoomReservation(Users u, Reservation r)
        {
            InitializeComponent();
            user = u;
            reservation = r;
        }

        private void EditRoomReservation_Load(object sender, EventArgs e)
        {
            lblRoomName.Text = reservation.Room.Name;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmUserHome(user), this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstDuration.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Duration !!");
                return;
            }
            else
            {
                //string userid;
                //userid = $"{user.UserID}";
                string selectedRoom;
                selectedRoom = reservation.Room.Name;
                DateTime time = dateTimePicker.Value;
                int duration = int.Parse(lstDuration.SelectedItem.ToString().Replace(" Minutes", ""));

                

                /*
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select RoomID from Rooms where Name ='" + selectedRoom + "'";
                object CommandText = null;
                label1.Text = CommandText.ToString();
                cmd.ExecuteNonQuery();
                con.Close();
                */

                
                DatabaseBridge db = new DatabaseBridge();
                //string reserverid = "RR" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
                //Reservation reserve = new Reservation(reserverid, user, selectedRoom, time, duration);
                db.CommitToDB($"update Reservations set DateTime = '" + time +"' and Duration = '"+duration+"' where RoomID = '"+selectedRoom+$"' and UserID = '{user.UserID}'");
                

                /*
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Reservations set DateTime = '" + time + "', Duration = '" + duration + "' where RoomID = '" + selectedRoom + $"' and UserID = '{user.UserID}'";
                cmd.ExecuteNonQuery();
                con.Close();*/
                
                /*
                con.Open();
                SqlCommand cmd = new SqlCommand("update Reservations set DateTime = '" + time +"', Duration = '"+duration+"' where RoomID = '"+selectedRoom+$"' and UserID = '{user.UserID}'",con);
                cmd.ExecuteNonQuery();
                con.Close();*/
            }

            MessageBox.Show("Record Saved !!");
            Program.ReplaceForm(new frmUserHome(user), this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.ReplaceForm(new frmEditCancleRoom(user), this);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
