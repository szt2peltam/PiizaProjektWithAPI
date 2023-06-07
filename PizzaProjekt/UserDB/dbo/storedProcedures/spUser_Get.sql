CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin
	SELECT Id, Name, Password
	FROM dbo.[User]
	WHERE Id = @Id;
end
