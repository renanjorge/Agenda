using Agenda.Repository.Mappers;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Agenda.Infrastructure.Database
{
    public static class SessionFactory 
    {
        public static ISessionFactory CreateSessionFactory(string connectionString)
        {
            return Fluently.Configure()
                        .Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString)
                                                                .ShowSql())
                        .Mappings(m => m.FluentMappings.AddFromAssemblyOf<EventMap>())
                        .BuildSessionFactory();
        }
    }
}