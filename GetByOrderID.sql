
CREATE PROCEDURE [dbo].[SKUTABLE_GetByOrderID]
	@orderID int
AS 
	BEGIN
	SET NOCOUNT ON;

	select * from dbo.SKUTABLE
	where orderID = @orderID;
END