using Microsoft.AspNetCore.Mvc;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Service;

namespace Agenda.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertsController : ControllerBase
    {
        private readonly IAlertService alertService;

        public AlertsController(IAlertService alertService)
        { 
            this.alertService = alertService;
        }

        [HttpGet("{id}")]
        public ActionResult Show(int id)
        {
            var alert = alertService.FindById(id);

            if (alert == null)
                return NotFound();

            return Ok(alert);
        }

        [HttpPost]
        public ActionResult Create(Alert alert)
        {
            alertService.Save(alert);

            return Created("api/events", alert);                     
        }
        
        [HttpPut("{id}")]
        public ActionResult Update(int id, Alert alert)
        {
            alert.Id = id;
            alertService.Update(alert);

            return Ok(200);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            alertService.Delete(id);
            return Ok(200);
        }
    }
}
