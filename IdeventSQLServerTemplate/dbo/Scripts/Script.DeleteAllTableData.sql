﻿USE IdeventTestDB -- The script gives errors, but still removes all data from DB (maybe with a few exceptions?)
-- disable referential integrity
EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL' 

EXEC sp_MSForEachTable 'DELETE FROM ?' 

-- enable referential integrity again 
EXEC sp_MSForEachTable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL' 