﻿CREATE TABLE [dbo].[OwnerShipType]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL UNIQUE,
	CONSTRAINT [PK_OwnerShipType] PRIMARY KEY CLUSTERED([Id])
);
