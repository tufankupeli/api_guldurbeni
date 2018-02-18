using System;
using System.Web;
using System.Web.Http;

namespace Guldurbeni.Presentation.Controllers.Controllers.Generic
{
    public class ConfigurationsController : GenericBaseController
    {
        /// <summary>
        /// method return config_value in Configuration table which assigned with key
        /// </summary>
        /// <param name="key">string value of config key</param>
        /// <returns>string value of configuration</returns>
        [HttpGet, HttpPost]
        public string Get(string key)
        {

            var session = HttpContext.Current.Session;
            if (session != null)
            {
                if (session["Time"] == null)
                    session["Time"] = DateTime.Now;
                return "Session Time: " + session["Time"] + key;
            }
            return "Session is not availabe" + key;
        }
    }
}
