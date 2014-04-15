using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//类似在Assembly.cs文件
[assembly:log4net.Config.XmlConfigurator(ConfigFile="Configuration/log4net.config",Watch=true)]
namespace Core.Log.Logger
{
    public class Logger
    {
        //当前未指定logger，记录日志会使用root下的默认的appender
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(Logger));
        public static void WriteLog(Extension.CustomPatternMessage message, LogLevel level,Exception ex)
        {
            message = message ?? new Extension.CustomPatternMessage
            {
                Message = "Message",
                CityCode = "10",
                AppName = "AppName",
                SysName = "SysName",
                Machine = Environment.MachineName ?? String.Empty
            };
            switch(level)
            {
                case LogLevel.Debug:
                    Log.Debug(message, ex);
                    break;
                case LogLevel.Error:
                    Log.Error(message, ex);
                    break;
                case LogLevel.Fatal:
                    Log.Fatal(message, ex);
                    break;
                case LogLevel.Info:
                    Log.Info(message, ex);
                    break;
                case LogLevel.Warn:
                    Log.Warn(message, ex);
                    break;
                default:
                    Log.Info(message, ex);
                    break;
            }
        }
    }
}