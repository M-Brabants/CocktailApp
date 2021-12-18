CREATE PROCEDURE [dbo].[spCocktailInsert]
	@Id int,
	@Name nvarchar(20),
	@Description nvarchar(500),
	@Ingredient1 nvarchar(20),
	@Ingredient2 nvarchar(20),
	@Ingredient3 nvarchar(20),
	@Ingredient4 nvarchar(20),
	@Ingredient5 nvarchar(20),
	@Ingredient6 nvarchar(20)
AS
begin
	insert into dbo.Cocktail (Id, Name, Description, Ingredient1, Ingredient2, Ingredient3, Ingredient4, Ingredient5, Ingredient6)
	Values (@Id, @Name, @Description, @Ingredient1, @Ingredient2, @Ingredient3, @Ingredient4, @Ingredient5, @Ingredient6)
end
