using Core;
using DAL.CQRS;
using DAL.CQRS.Commands;
using DAL.CQRS.Queries;
using DAL.DAO;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests.DAL
{
    [TestFixture]
    public class UpdateAttributeNameTest: HandlerTestBase
    {
        [Test]
        public void UpdateTest()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            var updateAttributeNameCommandHandler = provider.GetService<ICommandHandler<UpdateAttributeNameCommand>>();
            updateAttributeNameCommandHandler.Handle(new UpdateAttributeNameCommand(1, "testAttributeName1"));

            var getAttributesQueryHandler = provider.GetService<IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>>();
            var attributes = getAttributesQueryHandler.Handle(new GetAttributesQuery()).ToList();

            Assert.AreEqual(attributes.FirstOrDefault(x => x.Id == 1)?.Name, "testAttributeName1");
        }
    }
}
