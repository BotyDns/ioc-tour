using DIContainer;
using DiTests.Classes;

namespace DiTests
{
    [TestClass]
    public class DIContainerTest
    {
        [TestMethod]
        public void TestSimpleClassResolution()
        {
            var builder = DIContainer.DIContainer.CreateBuilder();


            builder.ClassCollection.AddClass<ClassWithNoInterface>();

            var container = builder.Build();

            Assert.IsTrue(container.GetInstance<ClassWithNoInterface>() is ClassWithNoInterface);
        }
    }
}
