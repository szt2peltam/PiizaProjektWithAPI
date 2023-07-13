CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@Username nvarchar(50),
	@Password nvarchar(50),
	@birthDate date,
	@Firstname nvarchar(50),
	@SecondName nvarchar(50),
	@Gender nvarchar(50)
AS
BEGIN
	UPDATE dbo.[User]
	SET Username = @Username, Password = @Password, Gender = @Gender, FirstName = @Firstname, SecondName = @SecondName, BirthDate = @birthDate
	WHERE Id = @Id;
END

