using DIContainer;
using DIContainer.Interfaces;
using DiTests.Classes;

namespace DiTests
{
    [TestClass]
    public class DIContainerTest
    {
        private IContainerBuilder Builder { get; set; } = null!;

        [TestInitialize]
        public void Init()
        {
            Builder = DIContainer.DIContainer.CreateBuilder();
        }

        [TestMethod]
        public void TestSimpleClassResolution()
        {
            Builder.ClassCollection.AddClass<ClassWithNoInterface>();

            var container = Builder.Build();
            Assert.IsTrue(container.GetInstance<ClassWithNoInterface>() is ClassWithNoInterface);
        }

        [TestMethod]
        public void TestSimpleClassWithInterfaceResolution()
        {
            Builder.ClassCollection.AddClass<IInterface, ClassWithInterface>();

            var container = Builder.Build();
            Assert.IsTrue(container.GetInstance<IInterface>() is IInterface);
            Assert.IsTrue(container.GetInstance<IInterface>() is ClassWithInterface);
            Assert.IsTrue(container.GetInstance<ClassWithInterface>() is ClassWithInterface);
        }

        [TestMethod]
        public void TestExceptionIsThrownWhenClassIsNotRegistered()
        {
            var container = Builder.Build();

            Assert.ThrowsException<InvalidOperationException>(container.GetInstance<ClassWithInterface>);
            Assert.ThrowsException<InvalidOperationException>(container.GetInstance<IInterface>);
        }
    }
}
