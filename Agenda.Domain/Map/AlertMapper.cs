using System.Linq;
using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Map
{
    public static class AlertMap 
    {
        public static AlertDTO ToDTO(this Alert entity)
        {
            return new AlertDTO
            {
                Id = entity.Id,
                DateHour = entity.DateHour
            };
        }

        public static Alert ToEntity(this AlertDTO dto)
        {
            return new Alert
            {
                Id = dto.Id,
                DateHour = dto.DateHour
            };
        }
    }
}