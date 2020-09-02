using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Agenda.Domain.Entities 
{
    public class EventDate 
    {
        public virtual int Id { get; set; }
        public virtual DateTime Beginning { get; set; }
        public virtual DateTime Ending { get; set; }
        public virtual Boolean AllDay { get; set; }

        public virtual Event Event { get; set; }
        
        [JsonIgnore]
        public virtual IEnumerable<Alert> Alerts { get; set; }

        public EventDate() 
        {
            Event = new Event();
            Alerts = new List<Alert>();
        }
    }
}