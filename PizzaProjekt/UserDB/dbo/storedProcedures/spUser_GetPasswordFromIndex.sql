CREATE PROCEDURE [dbo].[spUser_GetPasswordFromIndex]
	@Id int
AS
BEGIN
	SELECT Password
	FROM dbo.[User]
	WHERE Id = @Id;
END
