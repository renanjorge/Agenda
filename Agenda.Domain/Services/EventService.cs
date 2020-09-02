using System;
using System.Collections.Generic;
using System.Linq;
using Agenda.Domain.DTO;
using Agenda.Domain.Entities;
using Agenda.Domain.Interfaces.Repository;
using Agenda.Domain.Interfaces.Service;
using Agenda.Domain.Map;

namespace Agenda.Domain.Services
{
    public class EventService : BaseService<Event>, IEventService
    {
        private IEventRepository eventRepository;
        private IEventDateRepository eventDateRepository;

        public EventService(IEventRepository eventRepository,
                            IEventDateRepository eventDateRepository) : base(eventRepository)
        {
            this.eventRepository = eventRepository;
            this.eventDateRepository = eventDateRepository;
        }

        public EventDTO SaveEvent(EventDTO eventDTO)
        {
            var oneEvent = eventDTO.ToEntity();
            var eventDates = eventDTO.EventDates.Select(x => x.ToEntity());

            using(var transaction = eventRepository.BeginTransaction())
            {
                try 
                {
                    eventRepository.Save(oneEvent);

                    foreach(var eventDate in eventDates)
                    {
                        eventDate.Event = oneEvent;
                        eventDateRepository.Save(eventDate);
                    }
                        
                    transaction.Commit();
                } 
                catch(Exception)
                {
                    transaction.Rollback();
                    return null;
                }             
            }

            oneEvent.EventDates = eventDates;
            eventDTO = oneEvent.ToDTO();

            return eventDTO; 
        }

        public EventDTO FindEventDatesBy(int id)
        {
            var oneEvent = eventRepository.FindById(id);

            if (oneEvent != null)
            {
                var eventDTO = oneEvent.ToDTO();
                return eventDTO;
            }

            return null;
        }

        public IEnumerable<EventDTO> FindEventsBy(DateTime beginning, DateTime ending)
        {
            var events = eventRepository.FindEventsBy(beginning, ending);

            var eventsDTO = events.Select(e => e.ToDTO());

            return eventsDTO;
        }
    }
}