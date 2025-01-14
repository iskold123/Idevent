﻿-- https://www.mssqltips.com/sqlservertip/6798/drop-all-tables-sql-server/ (source on how to make this code)
USE Idevent
GO
SELECT 'ALTER TABLE ' 
    + (OBJECT_SCHEMA_NAME(parent_object_id)) 
    + '.'  
    +  QUOTENAME(OBJECT_NAME(parent_object_id)) 
    + ' ' 
    + 'DROP CONSTRAINT' 
    + QUOTENAME(name)
FROM sys.foreign_keys
ORDER BY OBJECT_SCHEMA_NAME(parent_object_id), OBJECT_NAME(parent_object_id);
GO
