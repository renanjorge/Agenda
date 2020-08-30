using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;
using NHibernate;
using System.Linq;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventTypesController : ControllerBase
    {
        private readonly IEventTypeRepository eventTypeRepository;

        public EventTypesController(IEventTypeRepository eventTypeRepository) 
        {
            this.eventTypeRepository = eventTypeRepository;
        }

        [HttpGet]
        public ActionResult<EventType> Get() 
        {
            var eventTypes = eventTypeRepository.GetAll();
            return Ok(eventTypes);
        }
    }
}
