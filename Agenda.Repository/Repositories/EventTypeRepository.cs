using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Repository;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class EventTypeRepository : BaseRepository<EventType>, IEventTypeRepository 
    {
        public EventTypeRepository(ISession session) : base(session) {}
    }
}