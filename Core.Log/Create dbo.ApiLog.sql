USE [CentaMonitor]
GO

/****** 对象: Table [dbo].[ApiLog] 脚本日期: 2014/4/15 15:28:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ApiLog] (
    [LogId]        INT            IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [CityCode]     INT            NOT NULL,
    [AppName]      NVARCHAR (30)  NULL,
    [SysName]      NVARCHAR (255) NOT NULL,
    [FunName]      NVARCHAR (255) NOT NULL,
    [RequestTime]  DATETIME       NOT NULL,
    [ResponseTime] DATETIME       NOT NULL,
    [ResponseCode] NVARCHAR (255) NOT NULL,
    [XmlContent]   XML            NOT NULL,
    [CreateTime]   DATETIME       NOT NULL
);


