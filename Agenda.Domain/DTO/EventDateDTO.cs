using System;

namespace Agenda.Domain.DTO 
{
    public class EventDateDto 
    {
        public int Id { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }
        public Boolean AllDay { get; set; }
    }   
}