using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryReservation
{
    public class Rooms
    {
        private string rmid;
        private string roomName;
        private int roomCapacity;
        private string roomLocation;

        public Rooms(string rmid, string roomName, int roomCapacity, string roomLocation)
        {
            this.rmid = rmid;
            this.roomName = roomName;
            this.roomCapacity = roomCapacity;
            this.roomLocation = roomLocation;
        }

        public Rooms(string roomName, int roomCapacity, string roomLocation)
        {
            rmid = "unknown";
            this.roomName = roomName;
            this.roomCapacity = roomCapacity;
            this.roomLocation = roomLocation;
        }

        public string RoomID { get => rmid; set => rmid = value; }
        public string Name { get => roomName; set => roomName = value; }
        public int Capacity { get => roomCapacity; set => roomCapacity = value; }
        public string Location { get => roomLocation; set => roomLocation = value; }
    }
}
