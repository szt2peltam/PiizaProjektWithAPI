CREATE PROCEDURE [dbo].[spOrders_Delete]
	@OrderId int

AS
BEGIN
	DELETE
	FROM dbo.[Orders]
	WHERE OrderId = @OrderId;
END
