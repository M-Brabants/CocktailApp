CREATE TABLE [dbo].[Cocktail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] nvarchar(20) NULL, 
    [Description] NVARCHAR(500) NULL, 
    [Ingredient1] NVARCHAR(20) NULL,
    [Ingredient2] NVARCHAR(20) NULL,
    [Ingredient3] NVARCHAR(20) NULL,
    [Ingredient4] NVARCHAR(20) NULL,
    [Ingredient5] NVARCHAR(20) NULL,
    [Ingredient6] NVARCHAR(20) NULL
)
