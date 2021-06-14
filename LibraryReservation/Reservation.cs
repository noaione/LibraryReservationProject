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
        private string datetime;
        private string duration;
        public Reservation(string rrid, Users user, Rooms room, string datetime, string duration)
        {
            rrid = rrid;
            user = user;
            room = room;
            datetime = datetime;
            duration = duration;
        }
        public Reservation(string rrid, string user, string room, string datetime, string duration)
        {
            rrid = "unknown";
            user = "unknown";
            room = "unknown";
            this.datetime = datetime;
            this.duration = duration;
        }


        public string ReserveID { get => rrid; set => rrid = value; }
        public string UserID { get => UserID; set => UserID = value; }
        public string RoomID { get => RoomID; set => RoomID = value; }
        public string DateTime { get => DateTime; set => DateTime = value; }
        public string Duration { get => Duration; set => Duration = value; }
    }
}
