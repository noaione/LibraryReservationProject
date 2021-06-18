namespace LibraryReservation
{
    /// <summary>
    /// The Rooms class that will hold information about a Rooms
    /// </summary>
    public class Rooms
    {
        private string rmid;
        private string roomName;
        private int roomCapacity;
        private string roomLocation;

        /// <summary>
        /// Create a new rooms data.
        /// </summary>
        /// <param name="rmid">The room ID</param>
        /// <param name="roomName">The room Name</param>
        /// <param name="roomCapacity">The room capacity</param>
        /// <param name="roomLocation">The room location</param>
        public Rooms(string rmid, string roomName, int roomCapacity, string roomLocation)
        {
            this.rmid = rmid;
            this.roomName = roomName;
            this.roomCapacity = roomCapacity;
            this.roomLocation = roomLocation;
        }

        /// <summary>
        /// Create a new rooms data with Unknown ID
        /// </summary>
        /// <param name="roomName">The room Name</param>
        /// <param name="roomCapacity">The room capacity</param>
        /// <param name="roomLocation">The room location</param>
        public Rooms(string roomName, int roomCapacity, string roomLocation)
        {
            rmid = "unknown";
            this.roomName = roomName;
            this.roomCapacity = roomCapacity;
            this.roomLocation = roomLocation;
        }

        /// <summary>
        /// The room ID
        /// </summary>
        public string RoomID { get => rmid; set => rmid = value; }
        
        /// <summary>
        /// The room name
        /// </summary>
        public string Name { get => roomName; set => roomName = value; }

        /// <summary>
        /// The room capacity
        /// </summary>
        public int Capacity { get => roomCapacity; set => roomCapacity = value; }

        /// <summary>
        /// The room location
        /// </summary>
        public string Location { get => roomLocation; set => roomLocation = value; }
    }
}
