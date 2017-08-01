﻿CREATE TABLE [dbo].[City]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL UNIQUE,
	[CountryId] int,
	CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([Id])
);

GO

ALTER TABLE [dbo].[City] ADD CONSTRAINT [FK_CityCountry] FOREIGN KEY (CountryId)
REFERENCES [dbo].[Country]([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION;



