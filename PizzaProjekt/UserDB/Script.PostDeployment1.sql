IF NOT EXISTS(SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User] (Username,Password,BirthDate, FirstName, SecondName, Gender)
	VALUES ('Admin', 'Admin', '2004-04-08', 'Kiss', 'Pista', 'Férfi'),
		   ('GepSonka', '123456', '2003-06-05', 'Nagy', 'Imre', 'Férfi'),
		   ('Csarmin', 'Mario', '2003-06-04', 'Elemér', 'Kondrád', 'Nő');
END
IF NOT EXISTS(SELECT 1 FROM dbo.Orders)
BEGIN
	INSERT INTO dbo.[Orders]( UserID, DB, Sauce, Pepperoni,
							Ham, Bacon, Chicken, MincedMeat, Tomato,
							Pepper, Corn, Mushroom, Pineapple, Ruccola,
							EggDB, ExtraCheese)
	VALUES ( 1, 3, 'Paradicsomos', 1,1,0,1,0,1,0,0,1,0,0,0,0),
			( 2, 3, 'Tejfölös', 1,1,0,1,0,1,1,0,1,0,0,0,0),
			( 5, 3, 'Paradicsomos', 0,1,0,1,0,1,1,0,1,0,0,0,0),
			( 1, 3, 'Sajtos', 1,1,0,0,0,1,0,0,1,0,0,1,0)
END