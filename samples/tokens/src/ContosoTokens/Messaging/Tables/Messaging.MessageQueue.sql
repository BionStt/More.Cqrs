﻿CREATE TABLE [Messaging].[MessageQueue]
(
 MessageId UNIQUEIDENTIFIER NOT NULL DEFAULT(NEWSEQUENTIALID()) PRIMARY KEY NONCLUSTERED
,EnqueueTime DATETIME2 NOT NULL DEFAULT(GETUTCDATE())
,DueTime DATETIME2 NOT NULL DEFAULT(GETUTCDATE())
,Type NVARCHAR(256) NOT NULL
,Revision INT NOT NULL DEFAULT(1)
,Message VARBINARY(MAX) NOT NULL
);
GO

CREATE CLUSTERED INDEX IX_Messaging_Queue ON [Messaging].[MessageQueue]( EnqueueTime, MessageId );