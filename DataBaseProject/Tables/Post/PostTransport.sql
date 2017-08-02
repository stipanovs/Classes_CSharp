﻿CREATE TABLE [dbo].[PostTransport]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[PublicationDate] DATETIME NOT NULL,
	[DateFrom] DATE NOT NULL,
	[DateTo] DATE NOT NULL,
	[LocalityFromId] INT,
	[LocalityToId] INT,
	[Price] FLOAT,
	[TransportSpecificationId] INT,
    [AdditionalInformation] NVARCHAR(100),
	[UserId] INT NOT NULL,
	CONSTRAINT [PK_PostTransport] PRIMARY KEY CLUSTERED ([Id]),
	CONSTRAINT [PostTransportLocalityFromId] FOREIGN KEY ([LocalityFromId])
	REFERENCES [dbo].[Locality]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [PostTransportLocalityToId] FOREIGN KEY ([LocalityToId])
	REFERENCES [dbo].[Locality]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [TransportSpecificationId] FOREIGN KEY ([TransportSpecificationId])
	REFERENCES [dbo].[TranportSpecification]([Id]) ON DELETE NO ACTION,
	CONSTRAINT [PostTransportUserId] FOREIGN KEY ([UserId])
	REFERENCES [dbo].[User]([Id]) ON DELETE NO ACTION
)
