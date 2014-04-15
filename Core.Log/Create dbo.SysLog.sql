USE [CentaMonitor]
GO

/****** 对象: Table [dbo].[SysLog] 脚本日期: 2014/4/15 15:27:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysLog] (
    [Id]        INT            NULL,
    [CityCode]  INT            NULL,
    [AppName]   NVARCHAR (30)  NULL,
    [Date]      DATETIME       NULL,
    [SysName]   NVARCHAR (255) NULL,
    [Thread]    NVARCHAR (255) NULL,
    [Level]     NVARCHAR (50)  NULL,
    [Logger]    NVARCHAR (255) NULL,
    [Message]   NVARCHAR (MAX) NULL,
    [Exception] NVARCHAR (MAX) NULL,
    [Machine]   VARCHAR (40)   NULL
);


