CREATE TABLE [dbo].[LocalityPlace]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(70) NOT NULL UNIQUE,
	[PlaceTypeId] INT,
	[CountryId] INT,
	CONSTRAINT [PK_LocalityPlace] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [LocalityTypeId] FOREIGN KEY([PlaceTypeId]) REFERENCES 
	[dbo].[LocalityPlaceType]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [LPCountryId] FOREIGN KEY([CountryId]) REFERENCES 
	[dbo].[Country]([Id]) ON DELETE NO ACTION
);


