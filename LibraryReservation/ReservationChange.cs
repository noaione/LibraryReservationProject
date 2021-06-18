using System;

namespace LibraryReservation
{
    /// <summary>
    /// The status of the approval of the reservation changes request
    /// </summary>
    public enum ChangeApproval
    {
        /// <summary>
        /// The change is approved
        /// </summary>
        Approved = 1,

        /// <summary>
        /// The change is denied
        /// </summary>
        Denied = -1,

        /// <summary>
        /// The change is still not processed by admin yet
        /// </summary>
        NotProcessed = 0,
    }

    /// <summary>
    /// The reservation changes class, hold data of any changes requested for a reservation.
    /// </summary>
    public class ReservationChange
    {
        private string changeId;
        private Reservation oldReserve;
        private Rooms newRoom;
        private DateTime newDate;
        private int newDuration;
        private DateTime timestamp;
        private string reasoning;
        private ChangeApproval approved;

        /// <summary>
        /// Create a new reservation changes based on old Reservation only
        /// </summary>
        /// <param name="oldReservation">The old reservation data</param>
        public ReservationChange(Reservation oldReservation)
        {
            changeId = "CH" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString() + "-" + oldReservation.ReserveID;
            oldReserve = oldReservation;
            newRoom = oldReservation.Room;
            newDate = oldReservation.DateTime;
            newDuration = oldReservation.Duration;
            timestamp = DateTime.UtcNow;
            reasoning = "No reason";
            approved = ChangeApproval.NotProcessed;
        }

        /// <summary>
        /// Create a new reservation changes containing data from old reservation and new stuff
        /// </summary>
        /// <param name="oldReservation">The old reservation data</param>
        /// <param name="newRoom">New room for the reservation</param>
        /// <param name="newDate">New date for the reservation</param>
        /// <param name="newDuration">New duration for the reservation</param>
        public ReservationChange(Reservation oldReservation, Rooms newRoom, DateTime newDate, int newDuration)
        {
            changeId = "CH" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            oldReserve = oldReservation;
            this.newRoom = newRoom;
            this.newDate = TimeZoneInfo.ConvertTimeToUtc(newDate);
            this.newDuration = newDuration;
            timestamp = DateTime.UtcNow;
            reasoning = "No reason";
            approved = ChangeApproval.NotProcessed;
        }

        /// <summary>
        /// Create a new reservation changes containing data from old reservation and new stuff including the reason
        /// </summary>
        /// <param name="oldReservation">The old reservation data</param>
        /// <param name="newRoom">New room for the reservation</param>
        /// <param name="newDate">New date for the reservation</param>
        /// <param name="newDuration">New duration for the reservation</param>
        /// <param name="reason">The reason the user want to change the reservation</param>
        public ReservationChange(Reservation oldReservation, Rooms newRoom, DateTime newDate, int newDuration, string reason)
        {
            changeId = "CH" + new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
            oldReserve = oldReservation;
            this.newRoom = newRoom;
            this.newDate = TimeZoneInfo.ConvertTimeToUtc(newDate);
            this.newDuration = newDuration;
            timestamp = DateTime.UtcNow;
            reasoning = reason;
            approved = ChangeApproval.NotProcessed;
        }

        /// <summary>
        /// [Internal Use] Represent the data from database for changes.
        /// </summary>
        /// <param name="changeId">The change ID</param>
        /// <param name="oldReservation">The old reservation data</param>
        /// <param name="newRoom">New room for the reservation</param>
        /// <param name="newDate">New date for the reservation</param>
        /// <param name="newDuration">New duration for the reservation</param>
        /// <param name="timestamp">The timestamp of the change creation/request</param>
        /// <param name="reason">The reason the user want to change the reservation</param>
        /// <param name="isAprroved">Is the change approved or not</param>
        public ReservationChange(string changeId, Reservation oldReservation, Rooms newRoom, DateTime newDate, int newDuration, DateTime timestamp, string reason, int isAprroved)
        {
            this.changeId = changeId;
            oldReserve = oldReservation;
            this.newRoom = newRoom;
            this.newDate = TimeZoneInfo.ConvertTimeToUtc(newDate);
            this.newDuration = newDuration;
            this.timestamp = TimeZoneInfo.ConvertTimeToUtc(timestamp);
            reasoning = reason;
            if (isAprroved == 0)
            {
                approved = ChangeApproval.NotProcessed;
            }
            else if (isAprroved > 0)
            {
                approved = ChangeApproval.Approved;
            }
            else if (isAprroved < 0)
            {
                approved = ChangeApproval.Denied;
            }
        }

        /// <summary>
        /// [Internal Use] Represent the data from database for changes, but with the isApproved as
        /// Enum of ChangeApproval
        /// </summary>
        /// <param name="changeId">The change ID</param>
        /// <param name="oldReservation">The old reservation data</param>
        /// <param name="newRoom">New room for the reservation</param>
        /// <param name="newDate">New date for the reservation</param>
        /// <param name="newDuration">New duration for the reservation</param>
        /// <param name="timestamp">The timestamp of the change creation/request</param>
        /// <param name="reason">The reason the user want to change the reservation</param>
        /// <param name="isAprroved">Is the change approved or not</param>
        public ReservationChange(string changeId, Reservation oldReservation, Rooms newRoom, DateTime newDate, int newDuration, DateTime timestamp, string reason, ChangeApproval isAprroved)
        {
            this.changeId = changeId;
            oldReserve = oldReservation;
            this.newRoom = newRoom;
            this.newDate = TimeZoneInfo.ConvertTimeToUtc(newDate);
            this.newDuration = newDuration;
            this.timestamp = TimeZoneInfo.ConvertTimeToUtc(timestamp);
            reasoning = reason;
            approved = isAprroved;
        }

        /// <summary>
        /// The ID representative
        /// </summary>
        public string ChangeID { get => changeId; }

        /// <summary>
        /// The old reservation data
        /// </summary>
        public Reservation OldReservation { get => oldReserve; set => oldReserve = value; }

        /// <summary>
        /// The new reservation data
        /// </summary>
        public Reservation NewReservation {
            get {
                Reservation newReserve = new Reservation(OldReservation.ReserveID, OldReservation.User, newRoom, newDate, newDuration);
                return newReserve;
            }
        }

        /// <summary>
        /// The new Rooms data
        /// </summary>
        public Rooms NewRoom { get => newRoom; set => newRoom = value; }

        /// <summary>
        /// The new DateTime data, in UTC.
        /// If being set, it automatically converted to UTC.
        /// </summary>
        public DateTime NewDate { get => newDate; set => newDate = TimeZoneInfo.ConvertTimeToUtc(value); }

        /// <summary>
        /// The new duration
        /// </summary>
        public int NewDuration { get => newDuration; set => newDuration = value; }

        /// <summary>
        /// The reason the reservation being changed.
        /// If the input is null or only whitespace or empty, it will be set as "No reason"
        /// </summary>
        public string Reason {
            get {
                return reasoning;
            }
            set {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    reasoning = "No reason";
                }
                else
                {
                    reasoning = value;
                }
            }
        }

        /// <summary>
        /// The creation of the change timestamp
        /// </summary>
        public DateTime Timestamp { get => timestamp; }

        /// <summary>
        /// Is the reservation changes accepted or not
        /// </summary>
        public ChangeApproval Approved { get => approved; set => approved = value; }

        /// <summary>
        /// Is the reservation changes accepted or not, representated by integer of
        /// 0: Not processed
        /// 1: Accepted
        /// -1: Denied
        /// </summary>
        public int ApprovedFlag {
            get {
                if (approved == ChangeApproval.Approved)
                {
                    return 1;
                }
                else if (approved == ChangeApproval.Denied)
                {
                    return -1;
                }
                return 0;
            }
        }

        /// <summary>
        /// Used internally to show a nice formatted message on the forms.
        /// Example formatting: "[Timestamp] ChangeID"
        /// </summary>
        public string DisplayData {
            get {
                string firstData = changeId.Split('-')[0];
                return $"[{timestamp:yyyy/MM/dd HH:mm}] {firstData}";
            }
        }
    }
}