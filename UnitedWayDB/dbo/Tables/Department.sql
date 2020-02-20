CREATE TABLE [dbo].[Department] (
    [orgcode]               VARCHAR (10) NOT NULL,
    [uwcoordinator3]        VARCHAR (50) NULL,
    [uwcoordinator2]        VARCHAR (50) NULL,
    [uwcoordinator1]        VARCHAR (50) NULL,
    [division]              VARCHAR (50) NOT NULL,
    [departmentstatus]      BIT          NOT NULL,
    [departmentdatecreated] DATETIME     NOT NULL,
    [departmentlastedited]  DATETIME     NULL,
    PRIMARY KEY CLUSTERED ([orgcode] ASC)
);

