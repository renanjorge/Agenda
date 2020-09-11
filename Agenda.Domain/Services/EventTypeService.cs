using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Repository;
using Agenda.Domain.Interfaces.Service;

namespace Agenda.Domain.Services 
{
    public class EventTypeService : BaseService<EventType>, IEventTypeService
    {
        public EventTypeService(IEventTypeRepository eventTypeRepository) : base(eventTypeRepository) { }
    }
}