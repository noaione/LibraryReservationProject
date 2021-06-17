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
            // Custom datepicker formatting
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "ddd, dd MMM yyyy HH:mm";
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
                string selRoom = reservation.Room.RoomID;
                DateTime time = dateTimePicker.Value;
                int duration = int.Parse(lstDuration.SelectedItem.ToString().Replace(" Minutes", ""));
                reservation.DateTime = time;
                reservation.Duration = duration;

                DatabaseBridge db = new DatabaseBridge();
                Reservation conflicted = db.ReservationConflictCheck(reservation);
                if (conflicted != null)
                {
                    MessageBox.Show("Sorry, there's already someone else booking on that time.");
                    return;
                }
                db.CommitToDB($"UPDATE Reservations SET DateTime = '{reservation.DateTimeSQL}', Duration = {reservation.Duration} WHERE ReserveID = '{reservation.ReserveID}'");

                // bntr
                //kykny jg yg pilih bagian dateTimePickernya harus di bkin biar gk kepilih yg hari" kemarin, soalnya bisa, kyk gini nih
                //mau share screen jg?
                //sip aku nonton
                // ya
                // ok, gw sekalian nyari cara benerinnya
                /*ajg dah berhasil
                 * 
                 * sebelum gw lupa, kita harus cek kalo tanggal/durasi baru itu konflik apa enggak.o
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
