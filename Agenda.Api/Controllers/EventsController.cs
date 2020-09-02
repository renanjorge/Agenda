using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using System;
using Agenda.Domain.Interfaces.Service;
using Agenda.Domain.DTO;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventService eventService;

        public EventsController(IEventService eventService) 
        {
            this.eventService = eventService;
        }

        [HttpGet("{id}/event-dates")]
        public ActionResult<EventDTO> ShowEventDatesBy(int id)
        {
            var eventDTO = eventService.FindEventDatesBy(id);

            if (eventDTO == null)
                return NotFound();

            return Ok(eventDTO);
        }

        [HttpGet()]
        public ActionResult ShowEventsBy([FromQuery] DateTime beginning, [FromQuery] DateTime ending)
        {
             var eventsDTO = eventService.FindEventsBy(beginning, ending);

            if (eventsDTO == null)
                return NotFound();

            return Ok(eventsDTO);
        }

        [HttpPost()]
        public ActionResult Create(EventDTO eventDTO)
        {
            eventDTO = eventService.SaveEvent(eventDTO);

            if (eventDTO == null)
                return BadRequest();

            return Created("api/events", eventDTO);
        }
        
        [HttpPut("{id}")]
        public ActionResult Update(int id, Event oneEvent)
        {
            oneEvent.Id = id;
            eventService.Update(oneEvent);

            return Ok(200);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try 
            {
                eventService.Delete(id);
                return Ok(200);
            } catch(Exception ) 
            {
                return BadRequest();
            }
        }
    }
}