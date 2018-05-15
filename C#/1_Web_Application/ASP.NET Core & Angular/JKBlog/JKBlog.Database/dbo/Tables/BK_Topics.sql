﻿CREATE TABLE [dbo].[BK_Topics]
(
	[TopicId] INT NULL,
	[Title] NVARCHAR(20) NULL,
	[Description] NVarChar(200) Null,
	[Picture] VARBINARY(MAX) NULL,
	[PictureMimeType] VARCHAR(50) NULL,
	[PostDate] DATETIME2 NULL,
	[ModifyDate] DATETIME2 NULL,
	[ShowFlag] BIT NULL
);
GO