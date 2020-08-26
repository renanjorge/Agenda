using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertsController : ControllerBase
    {
        public AlertsController() { }

        [HttpGet]
        public ActionResult<Alert> Get()
        {
            var alerts = new Alert();

            return Ok(alerts);
        }

    }
}
