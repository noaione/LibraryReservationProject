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
            this.datetime = TimeZoneInfo.ConvertTimeToUtc(datetime);
            this.duration = duration;
        }

        public string ReserveID { get => rrid; set => rrid = value; }
        public Users User { get => user; }
        public string UserID { get => user.UserID; }
        public Rooms Room { get => room; }
        public string RoomID { get => room.RoomID; }
        public DateTime DateTime { get => datetime; set => datetime = TimeZoneInfo.ConvertTimeToUtc(value); }
        public string DateTimeText { get => datetime.AddHours(8).ToString("ddd, dd MMM yyyy HH:mm"); }
        public string DateTimeSQL { get => TimeZoneInfo.ConvertTimeToUtc(datetime).ToString("s"); }
        public int Duration { get => duration; set => duration = value; }
        public string DisplayList
        {
            get {
                // Aiman: Man, I hate timezone.
                // Force change UTC to MYT, by adding 8 hours
                string dt = datetime.AddHours(8).ToString("U");
                return $"{room.Name} - {dt} MYT";
            }
        }
    }
}
