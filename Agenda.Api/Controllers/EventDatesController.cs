using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventDatesController : ControllerBase
    {
        private readonly IEventDateRepository eventDateRepository;
        
        public EventDatesController(IEventDateRepository eventDateRepository) 
        { 
            this.eventDateRepository = eventDateRepository;
        }

        [HttpGet]
        public ActionResult<EventDate> Get() 
        {
            return Ok();
        }
    }
}
