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
        private string roomCapacity;
        private string roomLocation;

        public Rooms(string rmid, string roomName, int roomCapacity, string roomLocaiton)
        {
            this.rmid = rmid;
            this.roomName = roomName;
            roomCapacity = roomCapacity;
            this.roomLocation = roomLocation;
        }

        public Rooms(string roomName, int roomCapacity, string roomLocation)
        {
            rmid = "unknown";
            this.roomName = roomName;
            roomCapacity = roomCapacity;
            this.roomLocation = roomLocation;
        }

        private string roomID;
        private string name;
        private int capacity;
        private string location;

        public string RoomID { get => roomID; set => roomID = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Location { get => location; set => location = value; }
    }
}
