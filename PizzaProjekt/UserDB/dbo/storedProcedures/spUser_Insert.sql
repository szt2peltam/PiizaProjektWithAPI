CREATE PROCEDURE [dbo].[spUser_Insert]
	@Name nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	INSERT INTO dbo.[User] (Name, Password)
	VALUES (@Name, @Password);
END