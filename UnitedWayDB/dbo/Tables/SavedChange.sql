CREATE TABLE [dbo].[SavedChange] (
    [changeid]        INT          NOT NULL,
    [change_datetime] DATETIME     NOT NULL,
    [userid]          VARCHAR (30) NULL,
    [contributionid]  VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([changeid] ASC),
    FOREIGN KEY ([contributionid]) REFERENCES [dbo].[Contribution] ([contributionid]),
    FOREIGN KEY ([userid]) REFERENCES [dbo].[UserAccount] ([userid])
);

