﻿CREATE TABLE [dbo].[EventStandProducts]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Value] DECIMAL(18, 2) NOT NULL, 
    [FK_EventStandId] INT NOT NULL
)
