using Agenda.Domain.Entities;
using FluentNHibernate.Mapping;

namespace Agenda.Repository.Mappers
{
    public class AlertMap : ClassMap<Alert>
    {
        public AlertMap()
        {
            Table("Alert");
            Id(x => x.Id).GeneratedBy.Increment();

            Map(x => x.DateHour).CustomSqlType("DateTime2")
                                .Not.Nullable();

            Map(x => x.IdEventDate).Column("IdEventDate").Not.Nullable();
        }
    }
}
