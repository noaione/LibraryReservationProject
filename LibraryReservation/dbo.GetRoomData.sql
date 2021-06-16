Alter PROCEDURE [dbo].[GetRoomData]
	@RoomID nvarchar(10)
AS
select [DateTime],Duration from Reservations where RoomID=@RoomID  
RETURN 0