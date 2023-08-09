CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@Username nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@birthDate date,
	@Firstname nvarchar(50),
	@SecondName nvarchar(50),
	@Gender nvarchar(50),
	@Telnum nvarchar(50),
	@PostCode int,
	@City nvarchar(50),
	@Street nvarchar(50),
	@HouseNum int

AS
BEGIN
	UPDATE dbo.[User]
	SET Username = @Username, Password = @Password, Gender = @Gender, FirstName = @Firstname, SecondName = @SecondName, BirthDate = @birthDate, Email = @Email
	,Telnum = @Telnum, PostCode = @PostCode, City = @City, Street = @Street, HouseNum = @HouseNum
	WHERE Id = @Id;
END

