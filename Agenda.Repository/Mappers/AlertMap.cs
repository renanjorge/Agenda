using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Repository.Mappers
{
    public class AlertMap : ClassMap<Alert>
    {
        public AlertMap()
        {
            Table("Alert");
            Id(x => x.Id);

            Map(x => x.DateHour).CustomSqlType("DateTime2")
                                .Not.Nullable();

            References(x => x.EventDate).Not.Nullable()
                                        .Cascade.All();

        }
    }
}
