CREATE TABLE [dbo].[Contribution] (
    [contributionid]       VARCHAR (50) NOT NULL,
    [uwtype]               CHAR (1)     NULL,
    [uwmonthly]            INT          NULL,
    [uwmonths]             INT          NULL,
    [uwcontributionamount] INT          NULL,
    [uwdate]               DATE         NULL,
    [uwyear]               VARCHAR (4)  NULL,
    [cwid]                 VARCHAR (16) NULL,
    [agencyid]             VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([contributionid] ASC),
    FOREIGN KEY ([agencyid]) REFERENCES [dbo].[Agency] ([agencyid]),
    FOREIGN KEY ([cwid]) REFERENCES [dbo].[Employee] ([cwid])
);

