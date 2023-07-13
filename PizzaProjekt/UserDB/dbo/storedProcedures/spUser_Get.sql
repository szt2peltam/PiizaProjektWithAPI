CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin
	SELECT Id, Username, Password, FirstName, SecondName, BirthDate, Gender
	FROM dbo.[User]
	WHERE Id = @Id;
end
