using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Repository.Mappers
{
    public class EventDateMap : ClassMap<EventDate>
    {
        public EventDateMap()
        {
            Id(x => x.Id);

            Map(x => x.Beginning).CustomSqlType("DateTime2")
                                 .Not.Nullable();
            
            Map(x => x.Ending).CustomSqlType("DateTime2")
                              .Not.Nullable();
            
            Map(x => x.AllDay).Not.Nullable();

            References(x => x.Event).Column("IdEvent")
                                    .Not.Nullable()
                                    .Cascade.All();
        }
    }
}
