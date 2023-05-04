using Cloud.Demo.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigDemoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ConfigDemoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<KeyValuePair<string, string>> GetConfig()
        {
            var keys = _configuration.GetSection("AppSettings").AsEnumerable().ToList();
            return keys;
        }
    }
}
