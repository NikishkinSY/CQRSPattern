using DAL.CQRS;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLogic.Infrastructure
{
    public static class BusinessLogicRegistration
    {
        public static void AddBusinessLogic(this IServiceCollection services)
        {
            // Авторегистрация всех DbQueryHandlerBase и DbCommandHandlerBase из текущей сборки.
            services
                .Scan(scan => scan
                .FromCallingAssembly()
                .AddClasses(classes => classes.AssignableTo(typeof(IHandler)))
                .AsSelf()
                .WithTransientLifetime());
        }
    }
}
