using System;
using System.Collections.Generic;
using Agenda.Domain.Entities;

namespace Agenda.Domain.Interfaces.Repository
{
    public interface IEventRepository : IBaseRepository<Event> 
    {
        IEnumerable<Event> FindEventsBy(DateTime beginning, DateTime ending);
    }
}