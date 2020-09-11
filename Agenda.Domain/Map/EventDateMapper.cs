using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Map
{
    public static class EventDateMap 
    {
        public static EventDateDto ToDTO(this EventDate entity)
        {
            return new EventDateDto
            {
                Id = entity.Id,
                Beginning = entity.Beginning,
                Ending = entity.Ending,
                AllDay = entity.AllDay
            };
        }

        public static EventDate ToEntity(this EventDateDto dto)
        {
            return new EventDate
            {
                Id = dto.Id,
                Beginning = dto.Beginning,
                Ending = dto.Ending,
                AllDay = dto.AllDay
            };
        }
    }
}