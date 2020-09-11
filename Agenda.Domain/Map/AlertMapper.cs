using Agenda.Domain.DTO;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Map
{
    public static class AlertMap 
    {
        public static AlertDto ToDTO(this Alert entity)
        {
            return new AlertDto
            {
                Id = entity.Id,
                DateHour = entity.DateHour
            };
        }

        public static Alert ToEntity(this AlertDto dto)
        {
            return new Alert
            {
                Id = dto.Id,
                DateHour = dto.DateHour
            };
        }
    }
}