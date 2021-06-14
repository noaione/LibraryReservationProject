using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryReservation
{
    public class Reservation
    {
        private string rrid;
        private Users user;
        private Rooms room;
        private DateTime datetime;
        private int duration;
        public Reservation(string rrid, Users user, Rooms room, DateTime datetime, int duration)
        {
            this.rrid = rrid;
            this.user = user;
            this.room = room;
            this.datetime = datetime;
            this.duration = duration;
        }

        public string ReserveID { get => rrid; set => rrid = value; }
        public string UserID { get => user.UserID; }
        public string RoomID { get => room.RoomID; }
        public DateTime DateTime { get => datetime; set => datetime = value; }
        public string DateTimeSQL { get => datetime.ToString("s"); }
        public int Duration { get => duration; set => duration = value; }
    }
}
