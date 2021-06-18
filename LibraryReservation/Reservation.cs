using System;

namespace LibraryReservation
{
    /// <summary>
    /// The Reservation class that will hold Reservation data
    /// </summary>
    public class Reservation
    {
        private string rrid;
        private Users user;
        private Rooms room;
        private DateTime datetime;
        private int duration;

        /// <summary>
        /// Create a new reservation class.
        /// </summary>
        /// <param name="rrid">The reservation ID</param>
        /// <param name="user">The User doing the reservation</param>
        /// <param name="room">The Room that being reserved</param>
        /// <param name="datetime">The date and time the reservation taking place</param>
        /// <param name="duration">The duration of the reservation</param>
        public Reservation(string rrid, Users user, Rooms room, DateTime datetime, int duration)
        {
            this.rrid = rrid;
            this.user = user;
            this.room = room;
            this.datetime = TimeZoneInfo.ConvertTimeToUtc(datetime);
            this.duration = duration;
        }

        /// <summary>
        /// The Reservation ID
        /// </summary>
        public string ReserveID { get => rrid; set => rrid = value; }

        /// <summary>
        /// The User data of the reservation
        /// </summary>
        public Users User { get => user; }

        /// <summary>
        /// The UserID that reserve this
        /// </summary>
        public string UserID { get => user.UserID; }

        /// <summary>
        /// The Room that is being reserved
        /// </summary>
        public Rooms Room { get => room; }

        /// <summary>
        /// The Room ID being reserved.
        /// </summary>
        public string RoomID { get => room.RoomID; }

        /// <summary>
        /// The time it's being reserved, in UTC.
        /// If new data being set, it will automatically converted to UTC.
        /// </summary>
        public DateTime DateTime { get => datetime; set => datetime = TimeZoneInfo.ConvertTimeToUtc(value); }

        /// <summary>
        /// The representative of the datetime in MYT with this example formatting:
        /// Thu, 17 Jun 2021 00:00
        /// </summary>
        public string DateTimeText {
            get {
                // Convert back the UTC time to MYT
                // -------------------------------------
                // Reason for MYT because it's fun :)
                // My wish will be never working with Timezone related stuff, I hate it.
                // Whoever invented Timezone in programming should rethink their life decision.
                // - M. Izaz
                // "ddd, dd MMM yyyy HH:mm"
                return datetime.AddHours(8).ToString("ddd, dd MMM yyyy HH:mm");
            }
        }

        /// <summary>
        /// The datetime representative in SQL string format
        /// </summary>
        public string DateTimeSQL { get => TimeZoneInfo.ConvertTimeToUtc(datetime).ToString("s"); }

        /// <summary>
        /// The duration of the reservation
        /// </summary>
        public int Duration { get => duration; set => duration = value; }

        /// <summary>
        /// Used internally to show a nice formatted message on the forms.
        /// Example formatting: "Amber 1 - Thu, 17 Jun 2021 00:00 MYT"
        /// </summary>
        public string DisplayList
        {
            get {
                // Aiman: Man, I hate timezone.
                // Force change UTC to MYT, by adding 8 hours
                string dt = DateTimeText;
                return $"{room.Name} - {dt} MYT";
            }
        }
    }
}
