CREATE TABLE [dbo].[Bugs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectId] INT NOT NULL, 
    [TItle] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [BugStatus] INT NOT NULL, 
    [Priority] INT NOT NULL, 
    [CreatedById] NVARCHAR(128) NOT NULL,
    [AssignedToId] NVARCHAR(128) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(),   
    [ClosedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Comments] NVARCHAR(MAX) NOT NULL,
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate()
)
