CREATE TABLE [dbo].[UserAccount] (
    [userid]             VARCHAR (30) NOT NULL,
    [userstatus]         BIT          NOT NULL,
    [userdatecreated]    DATETIME     NOT NULL,
    [userdatelastedited] DATETIME     NULL,
    [roleid]             VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([userid] ASC),
    FOREIGN KEY ([roleid]) REFERENCES [dbo].[UserRole] ([roleid])
);

