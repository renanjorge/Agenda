using System;

namespace Agenda.Domain.Entities 
{
    public class Alert 
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DateHour { get; set; }

        public virtual EventDate EventDate { get;set; }
    }
}