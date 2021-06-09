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
    public partial class frmEditCancleRoom : Form
    {
        public frmEditCancleRoom()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*
            //Move the Name That User Select from lstRoom to frmEditRoomReservation
            int room = lstRoom.SelectedIndex;//blm kelar jdi maunya ada terpilih trus pindah
            bool room = false;//kalau sudah ada terpilih, yg dipilih itu dipindahkan ke frmEditRoomReservation
            if (room = true) //kalau tidak dia tetap di halaman tsb n bilang "You Haven't Select The Room"
            {
                MessageBox.Show("You Haven't Select The Room");
                new frmEditCancleRoom().Show();
                this.Hide();
            }
            else
            {
                new frmEditRoomReservation().Show();
                this.Hide();
            }*/

            //UNTUK SEMENTARA
            new frmEditRoomReservation().Show();
            this.Hide();
            //BLM KELAR
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmUserHome().Show();
            this.Hide();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            //HARUS ADA DIPILIH DULU ROOMNYA TRUS BISA DI CANCLE, KALAU TIDAK DIA MINTA ULANG U/DI PILIH
            MessageBox.Show("The Room Have Been Cancled"); // DELETE FROM DB
            new frmUserHome().Show();
            this.Hide();
            //BLM KELAR
        }
    }
}
