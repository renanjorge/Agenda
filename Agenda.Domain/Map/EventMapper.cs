using System.Linq;
using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Map
{
    public static class EventMap 
    {
        public static EventDto ToDTO(this Event entity)
        {
            return new EventDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Place = entity.Place,
                Note = entity.Note,
                EventType = new EventTypeDto
                {
                    Id = entity.EventType.Id,
                    Name = entity.EventType.Name,
                    HexColor = entity.EventType.HexColor
                },
                EventDates = entity.EventDates.Select(x => new EventDateDto 
                {
                    Id = x.Id,
                    Beginning = x.Beginning,
                    Ending = x.Ending,
                    AllDay = x.AllDay
                }).ToList()
            };
        }

        public static Event ToEntity(this EventDto dto)
        {
            return new Event
            {
                Id = dto.Id,
                Name = dto.Name,
                Place = dto.Place,
                Note = dto.Note,
                EventType = new EventType
                {
                    Id = dto.EventType.Id,
                    Name = dto.EventType.Name,
                    HexColor = dto.EventType.HexColor
                }
            };
        }
    }
}