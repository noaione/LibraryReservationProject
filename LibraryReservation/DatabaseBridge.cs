using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryReservation
{
    class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        {

        }

        public UserNotFoundException(string name)
            : base(String.Format("Failed to find User with data of: {0}", name))
        {

        }
    }

    class UserNameAlreadyExist : Exception
    {
        public UserNameAlreadyExist()
        {

        }

        public UserNameAlreadyExist(string name)
            : base(String.Format("Username {0} already exist", name))
        {

        }
    }

    class UnknownDatabaseException : Exception
    {
        public UnknownDatabaseException()
        {

        }

        public UnknownDatabaseException(string reasoning)
            : base(String.Format("A failure occured when trying to query/commit to database: {0}", reasoning))
        {

        }
    }

    class DatabaseBridge
    {
        private SqlConnection conn;

        public DatabaseBridge()
        {
            conn = new SqlConnection(new Secrets().SQLStringConnection);
        }

        public void Connect()
        {
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }

        /*
         * Check if the connection open or not.
         */
        public bool Connected {
            get => conn != null && conn.State == ConnectionState.Open;
        }

        public Users FindUserByUsername(string username)
        {
            if (!Connected)
            {
                Connect();
            }

            SqlCommand cmd = new SqlCommand(string.Format("select count(*) from Users where UserName='{0}'", username), conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count < 1)
            {
                throw new UserNotFoundException(username);
            }

            SqlCommand getUser = new SqlCommand(string.Format("select * from Users where UserName='{0}'", username), conn);
            SqlDataAdapter da = new SqlDataAdapter(getUser);
            var table = new DataTable();
            da.Fill(table);
            Close();
            da.Dispose();

            foreach (DataRow row in table.Rows)
            {
                string uuid = row["UserID"].ToString();
                string uname = row["UserName"].ToString();
                string fullname = row["FullName"].ToString();
                string hashpass = row["HashedPassword"].ToString();
                string type = row["Type"].ToString();
                UserType mapType;
                if (type == "admin")
                {
                    mapType = UserType.Librarian;
                } else
                {
                    mapType = UserType.Student;
                }
                Users udata = new Users(uuid, fullname, uname, hashpass, mapType);
                return udata;
            }
            throw new UserNotFoundException(username);
        }

        public Users CreateNewUser(Users userInfo)
        {
            if (!Connected)
            {
                Connect();
            }

            SqlCommand cmd = new SqlCommand(string.Format("select count(*) from Users where UserName='{0}'", userInfo.Username), conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count > 0)
            {
                throw new UserNameAlreadyExist(userInfo.Username);
            }

            SqlCommand commitCmd = new SqlCommand(string.Format("Insert Into Users values ('{0}', '{1}', '{2}', '{3}')", userInfo.Name, userInfo.Username, userInfo.HashedPassword, userInfo.TypeAsName), conn);
            int affected = commitCmd.ExecuteNonQuery();
            if (affected < 1)
            {
                throw new UnknownDatabaseException("Failed to insert new user to database");
            }

            try
            {
                Users user = FindUserByUsername(userInfo.Username);
                return user;
            } catch (UserNotFoundException)
            {
                throw new UnknownDatabaseException("Failed to insert new user to database");
            }
        }
    }
}
