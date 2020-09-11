using System;
using System.Collections.Generic;
using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces.Service 
{
    public interface IEventService : IBaseService<Event>
    {
        EventDto SaveEvent(EventDto eventDTO);
        EventDto FindEventDatesBy(int id);
        IEnumerable<EventDto> FindEventsBy(DateTime beginning, DateTime ending);
    }
}