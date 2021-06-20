# Library Reservation
An Introduction to Object-Oriented Programming project for university.

This project was made by Group 15.

## Setup
You need to have a database named LibraryDatabase in the project folder to start, and create a class named `LibrarySecrets` containing something like this:

```cs
namespace LibraryReservation
{
    class LibrarySecrets
    {
        public string SQLStringConnection;
        public string PassEntropy = "XXXXXXXXXXXXXX";
        public LibrarySecrets()
        {
            string DBFilePath = "Path\\To\\LibraryDatabase.mdf";
            SQLStringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + DBFilePath + ";Integrated Security=True";
        }
    }
}
```

After that craete a table with this query:<br />
`Users` table
```sql
CREATE TABLE [dbo].[Users] (
    [UserID]         INT            IDENTITY (1, 1) NOT NULL,
    [FullName]       NVARCHAR (50)  NOT NULL,
    [UserName]       NVARCHAR (50)  NOT NULL,
    [HashedPassword] NVARCHAR (MAX) NOT NULL,
    [Type]           NVARCHAR (50)  NOT NULL
);
```

`Rooms` table
```sql
CREATE TABLE [dbo].[Rooms] (
    [RoomID]   NVARCHAR (50) NOT NULL,
    [Name]     NVARCHAR (50) NOT NULL,
    [Capacity] INT           NOT NULL,
    [Location] NVARCHAR (50) NOT NULL
);
```

`Reservations` table
```sql
CREATE TABLE [dbo].[Reservations] (
    [ReserveID] NVARCHAR (50) NOT NULL,
    [UserID]    INT           NOT NULL,
    [RoomID]    NVARCHAR (50) NOT NULL,
    [DateTime]  DATETIME      NOT NULL,
    [Duration]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ReserveID] ASC),
    FOREIGN KEY ([RoomID]) REFERENCES [dbo].[Rooms] ([RoomID]),
    FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);
```

and `ReservationChanges` table
```sql
CREATE TABLE [dbo].[ReservationChanges] (
    [ChangesID]      NVARCHAR (50)  NOT NULL,
    [ReserveID]      NVARCHAR (50)  NOT NULL,
    [PreviousRoom]   NVARCHAR (50)  NOT NULL,
    [NewRoom]        NVARCHAR (50)  NOT NULL,
    [DateBefore]     DATETIME       NOT NULL,
    [DateAfter]      DATETIME       NOT NULL,
    [DurationBefore] INT            NOT NULL,
    [DurationAfter]  INT            NOT NULL,
    [Timestamp]      DATETIME       NOT NULL,
    [Reason]         NVARCHAR (MAX) NULL,
    [ApprovedFlag]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([ChangesID] ASC),
    FOREIGN KEY ([NewRoom]) REFERENCES [dbo].[Rooms] ([RoomID]),
    FOREIGN KEY ([PreviousRoom]) REFERENCES [dbo].[Rooms] ([RoomID]),
    FOREIGN KEY ([ReserveID]) REFERENCES [dbo].[Reservations] ([ReserveID])
);
```

After that, start the program and create a new user, you will need to set it manually as `admin` on the database.

## Acknowledgments
This project use Icons from [Material Design Icons](https://materialdesignicons.com/)
