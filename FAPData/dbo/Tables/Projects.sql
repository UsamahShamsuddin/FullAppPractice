CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectName] NVARCHAR(50) NOT NULL, 
    [ProjectStatus] INT NOT NULL, 
    [CreatedById] NVARCHAR(128) NOT NULL,
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [ClosedDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
