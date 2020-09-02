using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Service;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventTypesController : ControllerBase
    {
        private readonly IEventTypeService eventTypeService;

        public EventTypesController(IEventTypeService eventTypeService) 
        {
            this.eventTypeService = eventTypeService;
        }

        [HttpGet]
        public ActionResult Index() 
        {
            var eventTypes = eventTypeService.FindAll();

            if (eventTypes == null)
                return NotFound(eventTypes);

            return Ok(eventTypes);
        }

        [HttpGet("{id}")]
        public ActionResult Show(int id) 
        {
            var eventType = eventTypeService.FindById(id);

            if (eventType == null)
                return NotFound(eventType);

            return Ok(eventType);
        }

        [HttpPost()]
        public ActionResult Create([FromBody] EventType eventType) 
        {
            eventTypeService.Save(eventType);
            return Created("api/eventTypes", eventType);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, EventType eventType) 
        {
            eventType.Id = id;
            eventTypeService.Update(eventType);

            return Ok(eventType);      
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id) 
        {
            eventTypeService.Delete(id);
            return Ok(200);  
        }
    }
}