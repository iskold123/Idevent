﻿CREATE PROCEDURE [dbo].[spCreateChipGroup]
	@Name NVARCHAR(50),
	@FK_EventId INT
AS
BEGIN
INSERT INTO ChipGroups
OUTPUT INSERTED.Id
VALUES (@Name, @FK_EventId)
END
