using System.Collections.Generic;
using System.Linq;
using Core;
using DAL;
using DAL.CQRS;
using DAL.CQRS.Commands;
using DAL.CQRS.Queries;
using DAL.DAO;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

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
            updateAttributeNameCommandHandler.Handle(new UpdateAttributeNameCommand("testAttributeName1", 1));

            var getAttributesQueryHandler = provider.GetService<IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>>();
            var attributes = getAttributesQueryHandler.Handle(new GetAttributesQuery()).ToList();

            Assert.AreEqual(attributes.FirstOrDefault(x => x.Id == 1)?.Name, "testAttributeName1");
        }
    }
}
