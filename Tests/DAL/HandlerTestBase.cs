using Core;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Tests.DAL
{
    [TestFixture]
    public class HandlerTestBase
    {
        [OneTimeSetUp]
        public void TestInit()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            var dbValidator = provider.GetService<DbValidator>();
            dbValidator.CheckDb();
        }
    }
}
