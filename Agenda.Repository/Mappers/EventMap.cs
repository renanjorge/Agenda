using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Repository.Mappers
{
    public class EventMap : ClassMap<Event>
    {
        public EventMap()
        {
            Id(x => x.Id);

            Map(x => x.Name).Length(50)
                            .Not.Nullable();
            
            Map(x => x.Place).Length(300)
                             .Not.Nullable();

            Map(x => x.Note).Length(500)
                            .Not.Nullable();
            
            References(x => x.EventType).Column("IdEventType")
                                        .Not.Nullable()
                                        .Not.Cascade.Delete()
                                        .Cascade.SaveUpdate();
        }
    }
}
