using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventDatesController : ControllerBase
    {
        public EventDatesController() { }

        [HttpGet]
        public ActionResult<EventDate> Get() 
        {
            return Ok();
        }
    }
}
