CREATE TABLE [dbo].[TranportSpecification]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[TransportTypeId] INT,
    [WeightCapacity] INT,
	[VolumeCapacity] INT, 
	CONSTRAINT [PK_TransportSpecification] PRIMARY KEY ([Id]),
	CONSTRAINT [TransportTypeId] FOREIGN KEY ([TransportTypeId])
	REFERENCES [dbo].[TransportType]([Id]) ON DELETE NO ACTION
);
