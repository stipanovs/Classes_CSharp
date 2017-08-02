﻿CREATE TABLE [dbo].[Person]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[FirstName] NVARCHAR(50) NOT NULL,
	[LastName] NVARCHAR(50),
	[PhoneNumber] NVARCHAR(15),
	[Email] NVARCHAR(50),
	[Address] NVARCHAR(100),
	CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id])
	
);
