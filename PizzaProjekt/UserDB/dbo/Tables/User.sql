CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [BirthDate] Date NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [SecondName] NVARCHAR(50) NULL, 
    [Gender] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Telnum] NVARCHAR(50) NULL, 
    [PostCode] INT NULL, 
    [City] NVARCHAR(50) NULL, 
    [Street] NVARCHAR(50) NULL, 
    [HouseNum] INT NULL

)
