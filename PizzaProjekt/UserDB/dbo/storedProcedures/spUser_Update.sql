CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@Name nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	UPDATE dbo.[User]
	SET Name = @Name, Password = @Password
	WHERE Id = @Id;
END

