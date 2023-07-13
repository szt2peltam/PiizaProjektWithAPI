CREATE TABLE [dbo].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserID] INT NOT NULL, 
    [DB] INT NOT NULL, 
    [Type] NVARCHAR(50) NULL, 
    [Sauce] NVARCHAR(50) NULL, 
    [Pepperoni] INT NULL, 
    [Ham] INT NULL, 
    [Bacon] INT NULL, 
    [Chicken] INT NULL, 
    [MincedMeat] INT NULL, 
    [Tomato] INT NULL, 
    [Pepper] INT NULL, 
    [Corn] INT NULL, 
    [Mushroom] INT NULL, 
    [Pineapple] INT NULL,
    [Ruccola] INT NULL ,
    [EggDB] INT NULL, 
    [ExtraCheese] INT NULL
)
