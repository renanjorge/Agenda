using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Repository.Mappers
{
    public class EventTypeMap : ClassMap<EventType>
    {
        public EventTypeMap()
        {
            Table("EventType");
            
            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.Name).Length(50)
                            .Not.Nullable();

            Map(x => x.HexColor).Length(7)
                                .Nullable();
        }
    }
}
