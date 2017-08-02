CREATE TABLE [dbo].[PostCargo]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[PublicationDate] DATETIME NOT NULL,
	[DateFrom] DATE NOT NULL,
	[DateTo] DATE NOT NULL,
	[LocalityFromId] INT,
	[LocalityToId] INT,
	[Price] DECIMAL(10,2),
	[CargoSpecificationId] INT,
    [AdditionalInformation] NVARCHAR(100),
	[UserId] INT NOT NULL,
	CONSTRAINT [PK_PostCargo] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [PostCargoLocalityFromId] FOREIGN KEY ([LocalityFromId])
	REFERENCES [dbo].[Locality]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [PostCargoLocalityToId] FOREIGN KEY ([LocalityToId])
	REFERENCES [dbo].[Locality]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [CargoSpecificationId] FOREIGN KEY ([CargoSpecificationId])
	REFERENCES [dbo].[CargoSpecification]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [PostCargoUserId] FOREIGN KEY ([UserId])
	REFERENCES [dbo].[User]([Id]) ON DELETE NO ACTION,
	CHECK ([Price] > 0)
	
);
