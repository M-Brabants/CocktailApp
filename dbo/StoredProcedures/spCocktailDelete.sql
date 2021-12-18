CREATE PROCEDURE [dbo].[spCocktailDelete]
	@id int
AS
begin
	delete from dbo.Cocktail
	where Id = @id;
end
