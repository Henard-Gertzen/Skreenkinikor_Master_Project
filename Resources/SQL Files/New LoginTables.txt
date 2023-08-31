USE LoginDB;
GO

CREATE TABLE [dbo].[Login_Table] (
    [Id]        INT            IDENTITY(1, 1) NOT NULL PRIMARY KEY,
    [Username]  NVARCHAR(50)   NULL,
    [Password]  NVARCHAR(100)  NULL,
    [FirstName] NVARCHAR(50)   NULL,
    [LastName]  NVARCHAR(50)   NULL,
    [IsAdmin]   BIT            NULL
);

INSERT INTO [dbo].[Login_Table] (Username, Password, FirstName, LastName, IsAdmin)
VALUES ('admin', 'admin', 'Admin', 'Account', 1);

CREATE TABLE [dbo].[ResetPassword] (
    [RequestTimestamp] DATETIME      NOT NULL,
    [Username]         NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([RequestTimestamp] ASC)
);

