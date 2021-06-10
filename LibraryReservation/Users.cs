namespace LibraryReservation
{
    enum UserType
    {
        Student,
        Librarian,
    }

    class Users
    {
        private string uuid;
        private string fullname;
        private string username;
        private string hashedPassword;
        private UserType utype;

        public Users(string uuid, string fullname, string username, string hashedpassword, UserType type)
        {
            this.uuid = uuid;
            this.fullname = fullname;
            hashedPassword = hashedpassword;
            this.username = username;
            utype = type;
        }

        public Users(string fullname, string username, string hashedpassword)
        {
            uuid = "unknown";
            this.fullname = fullname;
            hashedPassword = hashedpassword;
            this.username = username;
            utype = UserType.Student;
        }

        public string UserID { get => uuid; }
        public string Name { get => fullname; set => fullname = value; }
        public string Username { get => username; set => username = value; }
        public string HashedPassword {
            get {
                return hashedPassword;
            }
            set {
                hashedPassword = value;
            }
        }
        public UserType Type {
            get {
                return utype;
            }
        }

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
