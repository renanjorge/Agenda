using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class EventDateRepository : BaseRepository<EventDate>, IEventDateRepository 
    {
        public EventDateRepository(ISession session) : base(session) {}
    }
}