using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Map
{
    public static class EventDateMap 
    {
        public static EventDateDTO ToDTO(this EventDate entity)
        {
            return new EventDateDTO
            {
                Id = entity.Id,
                Beginning = entity.Beginning,
                Ending = entity.Ending,
                AllDay = entity.AllDay
            };
        }

        public static EventDate ToEntity(this EventDateDTO dto)
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