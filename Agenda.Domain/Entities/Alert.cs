using System;
using System.Text.Json.Serialization;

namespace Agenda.Domain.Entities 
{
    public class Alert 
    {
        public virtual int Id { get; set; }
        public virtual DateTime DateHour { get; set; }
        public virtual int IdEventDate { get; set; }

        [JsonIgnore]
        public virtual EventDate EventDate { get;set; }
    }
}