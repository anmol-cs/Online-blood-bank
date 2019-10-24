CREATE TABLE [dbo].[login1] (
    [password] VARCHAR (50) NULL,
    [name]     VARCHAR (50) NULL,
    [email]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([email])
);

