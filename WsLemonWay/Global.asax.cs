using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WsLemonWay
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // On vérifie que le logger a un niveau de log suffisant
            if (Log.MonitoringLogger.IsInfoEnabled)
            {
                Log.MonitoringLogger.Info("Application Start");
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // On vérifie que le logger a un niveau de log suffisant
            if (Log.MonitoringLogger.IsInfoEnabled)
            {
                // On set la propriété "log_who" utilisée par log4net avec le login du user connecté
                log4net.ThreadContext.Properties["log_who"] = Util.GetCurrentUser();

                var msg = string.Format("Session Start - User: {0}", Util.GetCurrentUser());
                Log.MonitoringLogger.Info(msg);
            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}