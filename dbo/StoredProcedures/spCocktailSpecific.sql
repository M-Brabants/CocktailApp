CREATE PROCEDURE [dbo].[spCocktailSpecific]
	@id int
AS
begin
	select * from dbo.Cocktail
	where Id = @id;
end
