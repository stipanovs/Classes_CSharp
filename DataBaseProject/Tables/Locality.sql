CREATE TABLE [dbo].[Locality]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[LocalyPlaceId] INT,
	[AddressDetail] NVARCHAR(100) NOT NULL,
	CONSTRAINT [PK_Locality] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [LocalyPlaceId] FOREIGN KEY ([LocalyPlaceId]) REFERENCES
	[dbo].[LocalityPlace]([Id]) ON DELETE NO ACTION,
);
