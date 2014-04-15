using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
public enum LogLevel
{
    /// <summary>
    /// 调试
    /// </summary>
    [EnumMember]
    Debug = 0,
    /// <summary>
    /// 错误
    /// </summary>
    [EnumMember]
    Error = 1,
    /// <summary>
    /// 致命
    /// </summary>
    [EnumMember]
    Fatal = 2,
    /// <summary>
    /// 消息
    /// </summary>
    [EnumMember]
    Info = 3,
    /// <summary>
    /// 警告
    /// </summary>
    [EnumMember]
    Warn = 4
}
