using BusinessLogic.Commands;
using BusinessLogic.CQRS.CommandHandlers;
using Core;
using DAL.CQRS;
using DAL.CQRS.CommandHandlers;
using DAL.CQRS.Queries;
using DAL.CQRS.QueryHandlers;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Linq;
using Tests.DAL;

namespace Tests.BusinessLogic
{
    [TestFixture]
    public class UpdateAttributeTest : HandlerTestBase
    {
        [Test]
        public void GetTest()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            var handlerBuilder = provider.GetService<HandlerBuilder>();
            var updateAttributeCommandHandler = handlerBuilder.Build<UpdateAttributeCommandHandler>();
            updateAttributeCommandHandler.Process(new UpdateAttributeCommand(1, "testAttributeName1", "testAttributeDescription1"));

            var getAttributesQueryHandler = handlerBuilder.Build<GetAttributesQueryHandler>();
            var attributes = getAttributesQueryHandler.Handle(new GetAttributesQuery()).ToList();

            Assert.AreEqual(attributes.FirstOrDefault(x => x.Id == 1)?.Name, "testAttributeName1");
            Assert.AreEqual(attributes.FirstOrDefault(x => x.Id == 1)?.Description, "testAttributeDescription1");
        }
    }
}
