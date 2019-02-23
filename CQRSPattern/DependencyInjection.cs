using DAL;
using DAL.CQRS;
using DAL.CQRS.CommandHandlers;
using DAL.CQRS.Commands;
using DAL.CQRS.Queries;
using DAL.CQRS.QueryHandlers;
using DAL.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace CQRSPattern
{
    public static class DependencyInjection
    {
        public static ServiceProvider Init(string connectionString)
        {
            return new ServiceCollection()
                .AddScoped(s =>
                    new AttributeContext(
                        new DbContextOptionsBuilder<AttributeContext>().UseSqlite(connectionString).Options))
                .AddTransient<ICommandHandler<UpdateAttributeNameCommand>, UpdateAttributeNameCommandHandler>()
                .AddTransient<IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>, GetAttributesQueryHandler>()
                .BuildServiceProvider();
        }
    }
}
