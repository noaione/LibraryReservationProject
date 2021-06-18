namespace LibraryReservation
{
    /// <summary>
    /// The type of User Enum
    /// </summary>
    public enum UserType
    {
        /// <summary>
        /// User is a student
        /// </summary>
        Student,

        /// <summary>
        /// User is a Librarian or Admin
        /// </summary>
        Librarian,
    }

    /// <summary>
    /// The Users class that will hold User data
    /// </summary>
    public class Users
    {
        private string uuid;
        private string fullname;
        private string username;
        private string hashedPassword;
        private UserType utype;

        /// <summary>
        /// Create a new User data.
        /// </summary>
        /// <param name="uuid">The user ID</param>
        /// <param name="fullname">The user real name or full name</param>
        /// <param name="username">The user username</param>
        /// <param name="hashedpassword">The user hashed password, NOT a plain-text password</param>
        /// <param name="type">The user type</param>
        public Users(string uuid, string fullname, string username, string hashedpassword, UserType type)
        {
            this.uuid = uuid;
            this.fullname = fullname;
            hashedPassword = hashedpassword;
            this.username = username;
            utype = type;
        }

        /// <summary>
        /// Create a new Student data with unknown ID.
        /// </summary>
        /// <param name="fullname">The student real name or full name</param>
        /// <param name="username">The student username</param>
        /// <param name="hashedpassword">The student hashed password, NOT a plain-text password</param>
        public Users(string fullname, string username, string hashedpassword)
        {
            uuid = "unknown";
            this.fullname = fullname;
            hashedPassword = hashedpassword;
            this.username = username;
            utype = UserType.Student;
        }

        /// <summary>
        /// The user ID
        /// </summary>
        public string UserID { get => uuid; }

        /// <summary>
        /// The user real name or full name
        /// </summary>
        public string Name { get => fullname; set => fullname = value; }

        /// <summary>
        /// The user username
        /// </summary>
        public string Username { get => username; set => username = value; }

        /// <summary>
        /// The user hashed password.
        /// </summary>
        public string HashedPassword {
            get {
                return hashedPassword;
            }
            set {
                hashedPassword = value;
            }
        }

        /// <summary>
        /// The user type
        /// </summary>
        public UserType Type {
            get {
                return utype;
            }
        }

        /// <summary>
        /// The user type but as a string representative
        /// </summary>
        public string TypeAsName {
            get {
                if (utype == UserType.Librarian)
                {
                    return "admin";
                }
                return "student";
            }
        }
    }
}
