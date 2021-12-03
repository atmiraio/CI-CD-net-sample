using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace WebApi.DevOps.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnviromentController : ControllerBase
    {
        private readonly ILogger<EnviromentController> _logger;
        private readonly IConfiguration _config;

        public EnviromentController(ILogger<EnviromentController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet("getEnviroments")]
        public IEnumerable<Enviroment> GetEnviroments()
        {
            _logger.LogDebug("Call GetEnviroments");

            var enviroments = new List<Enviroment>();
            enviroments.Add(new Enviroment(1, "Development", "DEV"));
            enviroments.Add(new Enviroment(2, "Integration", "INT"));
            enviroments.Add(new Enviroment(3, "Preproduction", "PRE"));
            enviroments.Add(new Enviroment(4, "Production", "PRO"));
            return enviroments;
        }

        [HttpGet("checkEnviroment")]
        public string CheckEnviroment()
        {  _logger.LogDebug("Call CheckEnviroment");

            return $"The active enviroment is {_config["Config:Enviroment"]}";
          
        }
    }
}
