CREATE TABLE [dbo].[UserRole] (
    [roleid]             VARCHAR (30) NOT NULL,
    [rolename]           VARCHAR (30) NOT NULL,
    [roledatecreated]    DATETIME     NOT NULL,
    [roledatelastedited] DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([roleid] ASC)
);

