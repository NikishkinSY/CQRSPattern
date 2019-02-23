using Core;
using DAL.CQRS;
using DAL.CQRS.Queries;
using DAL.DAO;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace Tests.DAL
{
    [TestFixture]
    public class GetAttributesTest: HandlerTestBase
    {
        [Test]
        public void GetTest()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            var getAttributesQueryHandler = provider.GetService<IQueryHandler<GetAttributesQuery, IEnumerable<Attribute>>>();
            var attributes = getAttributesQueryHandler.Handle(new GetAttributesQuery()).ToList();

            Assert.IsNotEmpty(attributes);
        }
    }
}
