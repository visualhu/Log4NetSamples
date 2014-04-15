using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Log4Net_WebSite
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(Server.MapPath("~/Configuration/log4net.config")));
            for (int i = 0; i <5; i++)
            {
                 Exception exception = new Exception("WebSite test...");
                 Logger.WriteLog(null, LogLevel.Error, exception);
            }

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            try
            {
                var serverError = Server.GetLastError();
                
                Exception exception = new Exception("WebSite test...");
                Logger.WriteLog(null, LogLevel.Error, exception);
                //Logger.WriteLog(serverError.Message, exception);
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}