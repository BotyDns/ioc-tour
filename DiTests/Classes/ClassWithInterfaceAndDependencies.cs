namespace DiTests.Classes
{
    public class ClassWithInterfaceAndDependencies : IInterface
    {
        public ClassWithInterfaceAndDependencies(ClassWithNoInterface dep)
        {

        }
    }
}
