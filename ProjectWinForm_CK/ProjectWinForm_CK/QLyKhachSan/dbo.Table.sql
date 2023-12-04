CREATE TABLE [dbo].[rooms] (
    [roomid]   INT           IDENTITY (1, 1)  PRIMARY KEY,
    [roomNo]   VARCHAR (250) NOT NULL,
    [roomType] VARCHAR (250) NOT NULL,
    [bed]      VARCHAR (250) NOT NULL,
    [price]    BIGINT        NOT NULL,
    [booked]   VARCHAR (50)  DEFAULT ('NO') NULL
);