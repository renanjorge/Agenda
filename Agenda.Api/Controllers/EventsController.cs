using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        public EventsController() { }

        [HttpGet]
        public ActionResult<Event> Get()
        {
            var events = new Event();

            return Ok(events);
        }
    }
}
