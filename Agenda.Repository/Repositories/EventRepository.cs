using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces;

namespace Agenda.Repository.Repositories
{
    public class EventRepository : BaseRepository<Event>, IEventRepository 
    {

    }
}