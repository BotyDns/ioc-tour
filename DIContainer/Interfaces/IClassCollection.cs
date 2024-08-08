using DIContainer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer.Interfaces
{
    /// <summary>
    /// The class collection contains all classes that have been registered to the DI container.
    /// </summary>
    public interface IClassCollection
    {
        /// <summary>
        /// Adds a class to the collection. The given class can be instantiated with all of its dependencies.
        /// </summary>
        /// <typeparam name="TClass"></typeparam>
        /// <returns></returns>
        IClassCollection AddClass<TClass>();

        /// <summary>
        /// Registers a class that implements the given base class or interface. The given class can be instantiated with all of its dependencies.
        /// If the base class or interface is requested, then we will just instantiate the class registered with it.
        /// </summary>
        /// <typeparam name="TBase"></typeparam>
        /// <typeparam name="TClass"></typeparam>
        /// <returns></returns>
        IClassCollection AddClass<TBase, TClass>()
            where TClass : TBase;

        
        /// <summary>
        /// Tries to get the information of the class requested.
        /// </summary>
        /// <typeparam name="IBase"></typeparam>
        /// <returns> The information of the class, together with its implementation, if registered. </returns>
        ClassInfo? GetClassInfo<IBase>();
    }
}
