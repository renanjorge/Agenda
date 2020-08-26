using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventTypesController : ControllerBase
    {
        public EventTypesController() { }

        [HttpGet]
        public ActionResult<EventType> Get() 
        {
            return Ok(200);
        }
    }
}
