using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Agenda.Domain.Entities 
{
    public class Event 
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Place { get; set; }
        public virtual string Note { get; set; }
        
        public virtual EventType EventType { get; set; }
        
        [JsonIgnore]
        public virtual IEnumerable<EventDate> EventDates { get; set; }

        public Event()
        {
            EventDates = new List<EventDate>();
        }
    }
}