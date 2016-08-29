using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsLemonWay
{
    public static class Util
    {
        /// <summary>
        /// Retourne le login du user connecté
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentUser()
        {
            return System.Web.HttpContext.Current.User.Identity.Name;
        }
    }
}