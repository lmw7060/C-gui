CREATE TABLE [dbo].[Game] (
    [Id]    INT           NOT NULL,
    [Name]  NVARCHAR (50) NULL,
    [Pass]  NVARCHAR (50) NULL,
    [Good]  NVARCHAR (50) NULL,
    [Add]   NVARCHAR (50) NULL,
    [Phone] NVARCHAR (50) NULL,
    [email] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

