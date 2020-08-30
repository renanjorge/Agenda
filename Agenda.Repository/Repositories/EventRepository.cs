using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository 
    {
        public EventRepository(ISession session) : base(session) {}
    }
}