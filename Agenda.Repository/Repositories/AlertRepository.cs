using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Repository;
using NHibernate;

namespace Agenda.Repository.Repositories
{
    public class AlertRepository : BaseRepository<Alert>, IAlertRepository 
    {
        public AlertRepository(ISession session) : base(session) {}
    }
}