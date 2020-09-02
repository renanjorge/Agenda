using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Repository;
using Agenda.Domain.Interfaces.Service;

namespace Agenda.Domain.Services 
{
    public class AlertService : BaseService<Alert>, IAlertService
    {
        private IAlertRepository alertRepository;
        public AlertService(IAlertRepository alertRepository) : base(alertRepository) { }
    }
}