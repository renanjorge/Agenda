using System.Collections.Generic;

namespace Agenda.Domain.DTO 
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Note { get; set; }
        public EventTypeDto EventType { get; set; }
        public IEnumerable<EventDateDto> EventDates { get; set; }
    }   
}