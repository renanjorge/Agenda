using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository eventRepository;

        public EventsController(IEventRepository eventRepository) 
        {
            this.eventRepository = eventRepository;
        }

        [HttpGet]
        public ActionResult<Event> Get()
        {
            var events = eventRepository.GetAll();

            return Ok(events);
        }
    }
}
