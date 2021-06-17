using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string ChangeID { get => changeId; }
        public Reservation OldReservation { get => oldReserve; set => oldReserve = value; }
        public Reservation NewReservation
        {
            get {
                Reservation newReserve = new Reservation(OldReservation.ReserveID, OldReservation.User, newRoom, newDate, newDuration);
                return newReserve;
            }
        }
        public Rooms NewRoom { get => newRoom; set => newRoom = value; }
        public DateTime NewDate { get => newDate; set => newDate = TimeZoneInfo.ConvertTimeToUtc(value); }
        public int NewDuration { get => newDuration; set => newDuration = value; }
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
        public DateTime Timestamp { get => timestamp; }
        public ChangeApproval Approved { get => approved; set => approved = value; }
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
    }
}
