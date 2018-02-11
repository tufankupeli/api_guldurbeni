using System.Collections.Generic;
using System.Web.Http;

namespace guldurbeni.presentation.Controllers
{
    public class ConfigurationsController : ApiController
    {
        /// <summary>
        /// method return config_value in Configuration table which assigned with key
        /// </summary>
        /// <param name="key">string value of config key</param>
        /// <returns>string value of configuration</returns>
        // GET api/configurations/appVersion
        [Route("api/configurations/{key}")]
        [HttpGet, HttpPost]
        public string Get(string key)
        {
            return "value";
        }
    }
}
