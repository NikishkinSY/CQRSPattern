using Core;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Tests.Core
{
    [TestFixture]
    public class DbValidatorTest
    {
        [Test]
        public void TestDbValidator()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            var dvValidator = provider.GetService<DbValidator>();
            dvValidator.CheckDb();
        }
    }
}
