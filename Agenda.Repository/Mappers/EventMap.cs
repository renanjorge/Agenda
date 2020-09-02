using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Repository.Mappers
{
    public class EventMap : ClassMap<Event>
    {
        public EventMap()
        {
            Table("Event");
            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Name).Length(50)
                            .Not.Nullable();
            
            Map(x => x.Place).Length(300)
                             .Not.Nullable();

            Map(x => x.Note).Length(500)
                            .Not.Nullable();
            
            References(x => x.EventType).Column("IdEventType")
                                        .Not.Nullable()
                                        .Cascade.None();

            HasMany<EventDate>(x => x.EventDates).Cascade.SaveUpdate()
                                                 .Inverse()
                                                 .AsBag();
        }
    }
}
