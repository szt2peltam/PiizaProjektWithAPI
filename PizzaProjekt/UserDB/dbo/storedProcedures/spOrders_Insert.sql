CREATE PROCEDURE [dbo].[spOrders_Insert]
	@UserID INT,
	@DB INT,
	@Type NVARCHAR(50),
	@Sauce NVARCHAR(50),
	@Pepperoni int,
	@Ham int,
	@Bacon int,
	@Chicken int,
	@MincedMeat int,
	@Tomato int,
	@Pepper int,
	@Corn int,
	@Mushroom int,
	@Pineapple int,
	@Ruccola int,
	@EggDB int,
	@ExtraCheese int
AS
BEGIN
INSERT INTO dbo.[Orders]( UserID, DB, Type,Sauce, Pepperoni,
							Ham, Bacon, Chicken, MincedMeat, Tomato,
							Pepper, Corn, Mushroom, Pineapple, Ruccola,
							EggDB, ExtraCheese)
							
							
							VALUES (@UserId, @DB, @Type,@Sauce, @Pepperoni,@Ham,@Bacon, @Chicken, @MincedMeat, @Tomato, @Pepper, @Corn, @Mushroom, @Pineapple, @Ruccola, @EggDB, @ExtraCheese );
END