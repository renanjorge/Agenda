using System;

namespace Agenda.Domain.Entities 
{
    public class EventDate 
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime Beginning { get; set; }
        public virtual DateTime Ending { get; set; }
        public virtual Boolean AllDay { get; set; }

        public virtual Event Event { get; set; }
    }
}
