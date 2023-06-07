CREATE PROCEDURE [dbo].[spUser_GetIndexByName]
	@Name nvarchar(50)
AS
begin
	SELECT Id
	FROM dbo.[User]
	WHERE Name = @Name;
end
