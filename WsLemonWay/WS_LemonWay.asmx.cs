using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public int Fibonacci(int n)
        {
            if (n < 1 || n > 100) return -1;
            if (n == 1 || n == 2) return 1;

            var sqrt5 = Math.Sqrt(5);

            var bigPhi = (sqrt5 + 1) / 2;
            var miniPhi = bigPhi - 1;

            var result = (Math.Pow(bigPhi, n) - Math.Pow(-miniPhi, n)) / sqrt5;

            if (result > Int32.MaxValue)
                throw new ArgumentOutOfRangeException("n", string.Format("Fib({0}) will cause a 32-bit integer overflow.", n));

            return Convert.ToInt32(result);
        }
    }
}
