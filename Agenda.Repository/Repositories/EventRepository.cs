using System;
using System.Collections.Generic;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Repository;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository 
    {
        public EventRepository(ISession session) : base(session) { }

        public IEnumerable<Event> FindEventsBy(DateTime beginning, DateTime ending)
        {
            return session.QueryOver<Event>()
                          .JoinQueryOver<EventDate>(s => s.EventDates)
                          .Where(s => s.Beginning >= beginning).And(s => s.Ending <= ending)
                          .List();
        }
    }
}