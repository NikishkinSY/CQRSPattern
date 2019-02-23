using Core;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Tests.Core
{
    [TestFixture]
    public class DITest
    {
        [Test]
        public void DIInit()
        {
            var provider = DependencyInjection.Init(Consts.TestConnectionString);
            
            Assert.IsNotNull(provider);
        }
    }
}
