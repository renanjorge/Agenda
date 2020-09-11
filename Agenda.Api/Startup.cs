using Agenda.Domain.Interfaces.Repository;
using Agenda.Domain.Interfaces.Service;
using Agenda.Domain.Services;
using Agenda.Infrastructure.Database;
using Agenda.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NHibernate;

namespace Agenda.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("AgendaDB");
            
            var sessionFactory = SessionFactory.CreateSessionFactory(connectionString);

            services.AddSingleton<ISessionFactory>(sessionFactory);
            services.AddScoped<ISession>(factory =>
            {
                return sessionFactory.OpenSession();
            });
                
            services.AddScoped<IAlertRepository, AlertRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IEventTypeRepository, EventTypeRepository>();
            services.AddScoped<IEventDateRepository, EventDateRepository>();

            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IEventTypeService, EventTypeService>();
            services.AddScoped<IAlertService, AlertService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
