using Core;
using DAL;
using DAL.CQRS;
using DAL.CQRS.Commands;
using DAL.CQRS.Queries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using Attribute = DAL.DAO.Attribute;

namespace CQRSPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // init dependency injection service
            var provider = DependencyInjection.Init("Data Source=AttributesDb.db");

            // open db connection
            var context = provider.GetService<AttributeContext>();
            context.Database.OpenConnection();

            // create db and fill with data
            var dvValidator = provider.GetService<DbValidator>();
            dvValidator.CheckDb();

            // update command
            var updateAttributeNameCommandHandler = provider.GetService<ICommandHandler<UpdateAttributeNameCommand>>();
            updateAttributeNameCommandHandler.Handle(new UpdateAttributeNameCommand(1, "newAttributeName1"));

            // get query
            var getAttributesQueryHandler = provider.GetService<IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>>();
            var attributes = getAttributesQueryHandler.Handle(new GetAttributesQuery()).ToList();

            // close connection
            context.Database.CloseConnection();

            Console.ReadKey();
        }
    }
}
