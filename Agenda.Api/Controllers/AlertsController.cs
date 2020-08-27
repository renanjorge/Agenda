using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertsController : ControllerBase
    {
        private readonly IAlertRepository alertRepository;

        public AlertsController(IAlertRepository alertRepository)
        { 
            this.alertRepository = alertRepository;
        }

        [HttpGet]
        public ActionResult<Alert> Get()
        {
            var alerts = new Alert();

            return Ok(alerts);
        }

    }
}
