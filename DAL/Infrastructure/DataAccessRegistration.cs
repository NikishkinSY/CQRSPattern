using DAL.CQRS;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Infrastructure
{
    public static class DataAccessRegistration
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddTransient<UnitOfWorkFactory>();
            services.AddTransient<HandlerBuilder>();
            services
                .Scan(scan => scan
                .FromCallingAssembly()
                .AddClasses(classes => classes.AssignableTo(typeof(IHandler)))
                .AsSelf()
                .WithTransientLifetime());
        }
    }
}
