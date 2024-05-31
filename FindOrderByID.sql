
ALTER Procedure [dbo].[GetByOrderID]
	@orderID nvarchar(50)
AS 
	BEGIN
	SET NOCOUNT ON;

	select * from dbo.SKUTABLE
	where orderID = @orderID;
END