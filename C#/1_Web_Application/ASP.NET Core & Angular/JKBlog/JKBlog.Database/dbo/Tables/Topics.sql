﻿CREATE TABLE [dbo].[Topics]
(
	[TopicId] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Title] NVARCHAR(20) NOT NULL,
	[Description] NVarChar(200) NULL,
	[Picture] VARBINARY(MAX),
	[PictureMimeType] VARCHAR(50),
	[PostDate] DATETIME2 DEFAULT GETDATE() NULL,
	[ModifyDate] DATETIME2 DEFAULT GETDATE() NULL,
	[ShowFlag] BIT NOT NULL DEFAULT 1
);
GO

--Backup
CREATE TRIGGER trg_BackupTopics ON [dbo].[Topics]
AFTER DELETE
AS
BEGIN	
	INSERT INTO [dbo].[BK_Topics]
	SELECT * 
	FROM DELETED
END
GO