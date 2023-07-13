CREATE PROCEDURE [dbo].[spOrders_Get]
	@UserId int
AS
begin
	SELECT *
	FROM dbo.[Orders]
	WHERE UserID = @UserId;
end
