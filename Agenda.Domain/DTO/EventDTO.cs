using System.Collections.Generic;
using Agenda.Domain.Entities;

namespace Agenda.Domain.DTO 
{
    public class EventDTO 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Note { get; set; }
        public EventTypeDTO EventType { get; set; }
        public IEnumerable<EventDateDTO> EventDates { get; set; }
    }   
}