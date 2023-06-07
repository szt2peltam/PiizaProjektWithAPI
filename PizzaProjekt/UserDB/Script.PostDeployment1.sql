IF NOT EXISTS(SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User] (Name,Password)
	VALUES ('Admin', 'Admin'),
		   ('GepSonka', '123456'),
		   ('Csarmin', 'Mario');
END