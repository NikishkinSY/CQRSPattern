using BusinessLogic.Queries;
using BusinessLogic.QueryHandlers;
using Core;
using DAL.CQRS;
using NUnit.Framework;
using Tests.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.BusinessLogic
{
    [TestFixture]
    public class GetSquareTest : HandlerTestBase
    {
        [Test]
        public void GetTest()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            var handlerBuilder = provider.GetService<HandlerBuilder>();
            var updateAttributeCommandHandler = handlerBuilder.Build<GetSquareQueryHandler>();
            var square = updateAttributeCommandHandler.Process(new GetSquareQuery(2, 2));
            
            Assert.AreEqual(square, 4);
        }
    }
}
