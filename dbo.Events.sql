CREATE TABLE [dbo].[Events] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NULL,
    [Description] TEXT         NULL,
    [Location]    VARCHAR (50) NULL,
    [Date]        DATETIME     NULL,
    [Invited]     VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
	
);

