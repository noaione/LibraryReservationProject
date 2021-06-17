using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LibraryReservation
{
    class UserNotFoundException : Exception
    {
        /// <summary>
        /// An exception when the provided username cannot be found on database
        /// </summary>
        public UserNotFoundException()
        {

        }

        /// <summary>
        /// An exception when the provided username cannot be found on database
        /// </summary>
        /// <param name="name">The username itself</param>
        public UserNotFoundException(string name)
            : base(String.Format("Failed to find User with data of: {0}", name))
        {

        }
    }
    class RoomNotFoundException : Exception
    {
        /// <summary>
        /// An exception when the provided RoomID cannot be found on database
        /// </summary>
        public RoomNotFoundException()
        {

        }

        /// <summary>
        /// An exception when the provided RoomID cannot be found on database
        /// </summary>
        /// <param name="roomid">The room ID itself</param>
        public RoomNotFoundException(string roomid)
            : base(String.Format("Failed to find Room with data of: {0}", roomid))
        {

        }
    }

    class UserNameAlreadyExist : Exception
    {
        /// <summary>
        /// An exception when the provided username already used.
        /// </summary>
        public UserNameAlreadyExist()
        {

        }

        /// <summary>
        /// An exception when the provided username already used.
        /// </summary>
        /// <param name="name">The username itself</param>
        public UserNameAlreadyExist(string name)
            : base(String.Format("Username {0} already exist", name))
        {

        }
    }

    class UnknownDatabaseException : Exception
    {
        /// <summary>
        /// An exception occured while trying to do something with the database
        /// </summary>
        public UnknownDatabaseException()
        {

        }

        /// <summary>
        /// An exception occured while trying to do something with the database
        /// </summary>
        /// <param name="reasoning">The reason it failed</par   am>
        public UnknownDatabaseException(string reasoning)
            : base(String.Format("A failure occured when trying to query/commit to database: {0}", reasoning))
        {

        }
    }

    class DatabaseBridge
    {
        private SqlConnection conn;

        /// <summary>
        /// Create a Database Context/Bridge to help communicate with the database.
        /// Need the `LibrarySecrets.cs` to exist
        /// </summary>
        public DatabaseBridge()
        {
            conn = new SqlConnection(new LibrarySecrets().SQLStringConnection);
        }

        /// <summary>
        /// Open a new connection to the database
        /// </summary>
        public void Connect()
        {
            try
            {
                if (!Connected)
                {
                    conn.Open();
                }
            }
            catch (Exception)
            {
            }
            
        }

        /// <summary>
        /// Close the connection to the database
        /// </summary>
        public void Close()
        {
            if (Connected)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Is the connection been established or not
        /// </summary>
        public bool Connected {
            get => conn != null && conn.State == ConnectionState.Open;
        }

        /// <summary>
        /// Query the database and return the data as a DataTable
        /// </summary>
        /// <param name="sqlCmd">The SQL command to be run</param>
        /// <param name="dontClose">Should we close the connection after running this?, default to false</param>
        /// <returns>A DataTable containing the result from the Query</returns>
        public DataTable QueryDBAsTable(string sqlCmd, bool dontClose = false)
        {
            Connect();
            SqlCommand fetchData = new SqlCommand(sqlCmd, conn);
            SqlDataAdapter da = new SqlDataAdapter(fetchData);
            var dt = new DataTable();
            da.Fill(dt);
            if (!dontClose)
            {
                Close();
            }
            da.Dispose();
            return dt;
        }

        /// <summary>
        /// Query the database and return it as Array of IDataRecord
        /// </summary>
        /// <param name="sqlCmd">The SQL command to be run</param>
        /// <param name="dontClose">Should we close the connection after running this?, default to false</param>
        /// <returns>Array of IDataRecord</returns>
        public List<IDataRecord> QueryDBAsArray(string sqlCmd, bool dontClose = false)
        {
            Connect();
            SqlCommand fetchData = new SqlCommand(sqlCmd, conn);
            SqlDataReader reader = fetchData.ExecuteReader();
            List<IDataRecord> list = new List<IDataRecord>();

            while (reader.Read())
            {
                list.Add((IDataRecord)reader);
            }
            reader.Close();
            if (!dontClose)
            {
                Close();
            }
            return list;
        }

        public delegate void ProcessQueryRecordCallback(IDataRecord data);

        /// <summary>
        /// Query the database and process the data on a callback/delegates
        /// </summary>
        /// <param name="sqlCmd">The SQL command to be run</param>
        /// <param name="callback">The callback/delegate that will be called on every time there's data</param>
        public void QueryToDelegate(string sqlCmd, ProcessQueryRecordCallback callback)
        {
            Connect();
            SqlCommand fetchData = new SqlCommand(sqlCmd, conn);
            SqlDataReader reader = fetchData.ExecuteReader();
            while (reader.Read())
            {
                callback((IDataRecord)reader);
            }
            reader.Close();
            Close();
        }

        public T QuerySingleColumn<T>(string sqlCmd, int index = 0, bool dontClose = false)
        {
            Connect();
            SqlCommand fetchData = new SqlCommand(sqlCmd, conn);
            SqlDataReader reader = fetchData.ExecuteReader();
            reader.Read();

            T data = reader.GetFieldValue<T>(index);
            reader.Close();
            if (!dontClose)
            {
                Close();
            }
            return data;
        }

        /// <summary>
        /// Count how many data in a table
        /// </summary>
        /// <param name="table">The table to be queried</param>
        /// <param name="filter">Extra filter, like WHERE parameter</param>
        /// <param name="dontClose">Should we close the connection after running this?, default to false</param>
        /// <returns>The total data in the table and filter provided</returns>
        public int CountTable(string table, string filter = "", bool dontClose = false)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(string.Format("SELECT COUNT(*) FROM {0} {1}", table, filter), conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (!dontClose)
            {
                Close();
            }
            return count;
        }

        /// <summary>
        /// Commit a new data to database
        /// </summary>
        /// <param name="sqlCmd">The commit to be run</param>
        /// <param name="dontClose">Should we close the connection after running this?, default to false</param>
        /// <exception cref="UnknownDatabaseException">A general error when commiting to database</exception>
        public void CommitToDB(string sqlCmd, bool dontClose = false)
        {
            Connect();
            SqlCommand commitCmd = new SqlCommand(sqlCmd, conn);
            int affected = commitCmd.ExecuteNonQuery();
            if (!dontClose)
            {
                Close();
            }
            if (affected < 1)
            {
                throw new UnknownDatabaseException("Failed to insert new user to database");
            }
        }

        /// <summary>
        /// Find a user from Users database by the username
        /// </summary>
        /// <param name="username">The username to be searched on</param>
        /// <returns>The user if found, if not it will raise UserNotFoundException exception</returns>
        /// <exception cref="UserNotFoundException">If the given username cannot be found on database</exception>
        public Users FindUserByUsername(string username)
        {
            int count = CountTable("Users", string.Format("WHERE UserName='{0}'", username), true);
            if (count < 1)
            {
                throw new UserNotFoundException(username);
            }

            DataTable table = QueryDBAsTable(string.Format("SELECT * FROM Users WHERE UserName='{0}'", username));

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

        /// <summary>
        /// Find a user from Users database by the username
        /// </summary>
        /// <param name="username">The username to be searched on</param>
        /// <returns>The user if found, if not it will raise UserNotFoundException exception</returns>
        /// <exception cref="UserNotFoundException">If the given username cannot be found on database</exception>
        public Users FindUserByID(int userId)
        {
            int count = CountTable("Users", $"WHERE UserID={userId}", true);
            if (count < 1)
            {
                throw new UserNotFoundException($"UUID: {userId}");
            }

            DataTable table = QueryDBAsTable(string.Format("SELECT * FROM Users WHERE UserID = {0}", userId));

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
                }
                else
                {
                    mapType = UserType.Student;
                }
                Users udata = new Users(uuid, fullname, uname, hashpass, mapType);
                return udata;
            }
            throw new UserNotFoundException($"UUID: {userId}");
        }

        /// <summary>
        /// Find a user from Users database by the username
        /// </summary>
        /// <param name="username">The username to be searched on</param>
        /// <returns>The user if found, if not it will raise UserNotFoundException exception</returns>
        /// <exception cref="UserNotFoundException">If the given username cannot be found on database</exception>
        public Rooms FindRoomByID(string roomID, bool autoClose = false)
        {
            int count = CountTable("Rooms", string.Format("where RoomID='{0}'", roomID), true);
            if (count < 1)
            {
                throw new RoomNotFoundException(roomID);
            }

            DataTable table = QueryDBAsTable(string.Format("SELECT * FROM Rooms WHERE RoomID='{0}'", roomID), autoClose);

            foreach (DataRow row in table.Rows)
            {
                string ruuid = row["RoomID"].ToString();
                string rname = row["Name"].ToString();
                int rsize = int.Parse(row["Capacity"].ToString());
                string rlocation = row["Location"].ToString();

                Rooms room = new Rooms(ruuid, rname, rsize, rlocation);
                return room;
            }
            throw new RoomNotFoundException(roomID);
        }
        /// <summary>
        /// Create a new Users records
        /// </summary>
        /// <param name="userInfo">The user information</param>
        /// <returns>The added users with the new ID and Type</returns>
        /// <exception cref="UserNameAlreadyExist">If the username provided already exist on database</exception>
        /// <exception cref="UnknownDatabaseException">A general error when commiting to database</exception>
        public Users CreateNewUser(Users userInfo)
        {
            if (!Connected)
            {
                Connect();
            }

            int count = CountTable("Users", string.Format("where Username='{0}'", userInfo.Username), true);
            if (count > 0)
            {
                throw new UserNameAlreadyExist(userInfo.Username);
            }

            CommitToDB(string.Format("Insert Into Users values ('{0}', '{1}', '{2}', '{3}')", userInfo.Name, userInfo.Username, userInfo.HashedPassword, userInfo.TypeAsName), true);

            try
            {
                Users user = FindUserByUsername(userInfo.Username);
                Close();
                return user;
            } catch (UserNotFoundException)
            {
                Close();
                throw new UnknownDatabaseException("Failed to insert new user to database");
            }
        }

        public Reservation ReservationConflictCheck(Reservation newReservation)
        {
            string today = newReservation.DateTime.ToString("yyyy-MM-dd");
            DataTable dataReserved = QueryDBAsTable($"SELECT * FROM Reservations WHERE RoomID = '{newReservation.RoomID}' AND DateTime > '{today} 00:00:00'");

            Reservation conflict = null;
            foreach (DataRow data in dataReserved.Rows)
            {
                int duration = int.Parse(data["Duration"].ToString());
                Users rUser = FindUserByID(int.Parse(data["UserID"].ToString()));
                Rooms rRoom = FindRoomByID(data["RoomID"].ToString());
                DateTime startRange = DateTime.Parse(data["DateTime"].ToString()).ToUniversalTime();
                DateTime endRange = startRange.AddMinutes(duration);

                DateTime endTimeRange = newReservation.DateTime.AddMinutes(newReservation.Duration);

                long start1 = ((DateTimeOffset)startRange).ToUnixTimeSeconds();
                long end1 = ((DateTimeOffset)endRange).ToUnixTimeSeconds();
                long start2 = ((DateTimeOffset)newReservation.DateTime).ToUnixTimeSeconds();
                long end2 = ((DateTimeOffset)endTimeRange).ToUnixTimeSeconds();

                // Based on: https://stackoverflow.com/a/3786909
                if ((start2 >= start1 && start2 <= end1) ||
                    (end2 >= start1 && end2 <= end1))
                {
                    Console.WriteLine("Conflicted with something else, dont add it!");
                    conflict = new Reservation(data["ReserveID"].ToString(), rUser, rRoom, startRange, duration);
                    break;
                }
            }
            return conflict;
        }

        internal DataTable QueryToDelegate(string v)
        {
            throw new NotImplementedException();
        }
    }
}
