CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [BirthDate] Date NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [SecondName] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(50) NULL

)
