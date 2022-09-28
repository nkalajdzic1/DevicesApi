using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net;

namespace DevicesApi.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly HealthCheckService healthCheckService;
        private readonly ILogger<HealthController> _logger;

        public HealthController(HealthCheckService healthCheckService, ILogger<HealthController> logger)
        {
            this.healthCheckService = healthCheckService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> GetHealth()
        {
            _logger.LogInformation(message: $"{nameof(HealthController)}.{nameof(HealthController.GetHealth)} called.");
            HealthReport report = await this.healthCheckService.CheckHealthAsync();
            
            var result = new
            {
                status = report.Status.ToString(),
                errors = report.Entries.Select(e => new 
                    { 
                        name = e.Key, 
                        upTime = e.Value.Duration,
                        status = e.Value.Status.ToString(), 
                        description = e.Value.Description 
                    }
                )
            };

            return report.Status == HealthStatus.Healthy 
                   ? this.Ok(result) 
                   : this.StatusCode((int)HttpStatusCode.ServiceUnavailable, result);
        }
    }
}
