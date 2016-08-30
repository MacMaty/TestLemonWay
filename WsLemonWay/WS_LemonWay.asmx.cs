using log4net;
using log4net.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;

namespace WsLemonWay
{
    /// <summary>
    /// Description résumée de WS_LemonWay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WS_LemonWay : System.Web.Services.WebService
    {
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public int Fibonacci(int n)
        {
            log4net.ThreadContext.Properties["log_who"] = Util.GetCurrentUser();
            if (Log.MonitoringLogger.IsInfoEnabled)
            {
                Log.MonitoringLogger.Info("Start Fibonacci");
            }
            if (n < 1 || n > 100) return -1;
            if (n == 1 || n == 2) return 1;

            var sqrt5 = Math.Sqrt(5);

            var bigPhi = (sqrt5 + 1) / 2;
            var miniPhi = bigPhi - 1;

            var result = (Math.Pow(bigPhi, n) - Math.Pow(-miniPhi, n)) / sqrt5;

            if (result > Int32.MaxValue)
            {
                var message = string.Format("Fib({0}) will cause a 32-bit integer overflow.", n);
                if (Log.MonitoringLogger.IsErrorEnabled)
                {
                    Log.MonitoringLogger.Error(message);
                }
                
                throw new ArgumentOutOfRangeException("n", message);
            }

            if (Log.MonitoringLogger.IsDebugEnabled)
            {
                Log.MonitoringLogger.Debug(string.Format("Value : {0}", result));
            }

            if (Log.MonitoringLogger.IsInfoEnabled)
            {
                Log.MonitoringLogger.Info("End Fibonacci");
            }

            return Convert.ToInt32(result);
        }

        [WebMethod]
        public string XMLToJSON(string xml)
        {
            if (Log.MonitoringLogger.IsInfoEnabled)
            {
                Log.MonitoringLogger.Info("Start XMLToJson");
            }
            try
            {
                XmlDocument document = new XmlDocument();
                // Load the XmlDocument with the XML.
                document.LoadXml(xml);

                // Convert XML to Json format
                string jsonText = JsonConvert.SerializeXmlNode(document, Newtonsoft.Json.Formatting.Indented);

                if (Log.MonitoringLogger.IsInfoEnabled)
                {
                    Log.MonitoringLogger.Info("End XMLToJson");
                }

                return jsonText;
            }
            catch (XmlException)
            {
                return "Bad Xml format";
            }
        }
    }
}
