using System;
using System.Collections.Generic;
using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces.Service 
{
    public interface IEventService : IBaseService<Event>
    {
        EventDTO SaveEvent(EventDTO eventDTO);
        EventDTO FindEventDatesBy(int id);
        IEnumerable<EventDTO> FindEventsBy(DateTime beginning, DateTime ending);
    }
}