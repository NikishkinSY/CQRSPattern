using BusinessLogic.CQRS.CommandHandlers;
using BusinessLogic.Infrastructure;
using DAL;
using DAL.CQRS;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class DependencyInjection
    {
        public static ServiceProvider Init(string connectionString)
        {
            var serviceCollection = new ServiceCollection()
                .AddScoped(s =>
                    new AttributeContext(
                        new DbContextOptionsBuilder<AttributeContext>().UseSqlite(connectionString).Options))
                //.AddTransient<ICommandHandler<UpdateAttributeNameCommand>, UpdateAttributeNameCommandHandler>()
                //.AddTransient<IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>, GetAttributesQueryHandler>()
                .AddTransient<DbValidator>()
                .AddTransient<HandlerBuilder>();
            //.BuildServiceProvider();

            DataAccessRegistration.AddDataAccess(serviceCollection);
            BusinessLogicRegistration.AddBusinessLogic(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }
    }
}
