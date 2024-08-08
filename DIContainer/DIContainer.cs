using DIContainer.Implementations;
using DIContainer.Interfaces;
using DIContainer.Util;
using System.Reflection;

namespace DIContainer
{
    /// <summary>
    /// The DI container is the heart of dependency injection in this project.
    /// </summary>
    public class DIContainer
    {
        public IClassCollection ClassCollection { get; init; } = null!;

        public DIContainer()
        { 
        }

        /// <summary>
        /// Gets an instance for the given base class, interface, or implementation, if it was registered.
        /// </summary>
        /// <typeparam name="IBase"> The name of the class. </typeparam>
        /// <returns> An instance of the given base class, interface, or implementation. </returns>
        /// <exception cref="InvalidOperationException"> thrown if the class is not found. </exception>
        public IBase GetInstance<IBase>()
        {
            ClassInfo? info = ClassCollection.GetClassInfo<IBase>() 
                ?? throw new InvalidOperationException("The given class was not registered.");

            ConstructorInfo[] constructors = info.Implementation.GetConstructors();

            if (constructors.Length == 0)
                throw new InvalidOperationException("The given class does not have any public constructors!");

            ConstructorInfo con = constructors[0];
            return (IBase) con.Invoke(null);
        }

        /// <summary>
        /// Creates a container builder to help create and configure the DI Container.
        /// </summary>
        /// <returns></returns>
        public static IContainerBuilder CreateBuilder()
            => new ContainerBuilder();
    }
}
