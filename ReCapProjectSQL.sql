CREATE TABLE [dbo].[Colors]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL
)
CREATE TABLE [dbo].[Brands]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL
)
CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandId ] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] FLOAT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    CONSTRAINT [FK_Cars_ToColors] FOREIGN KEY ([ColorId]) REFERENCES [Colors]([Id]),
	    CONSTRAINT [FK_Cars_ToBrands] FOREIGN KEY ([BrandId]) REFERENCES [Brands]([Id])

)
