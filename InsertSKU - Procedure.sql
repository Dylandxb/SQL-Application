CREATE Procedure [dbo].[SKUTABLE_InsertNewSKU]
	@orderID int
AS 
	BEGIN
	SET NOCOUNT ON;

	select * from dbo.SKUTABLE
	where orderID = @orderID;
END