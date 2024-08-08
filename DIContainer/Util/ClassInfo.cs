namespace DiContainer.Util
{
    /// <summary>
    /// Describes the information needed for the DI to be able to search and instantiate a class.
    /// </summary>
    public class ClassInfo
    {
        /// <summary>
        /// The type of the base class.
        /// </summary>
        public Type? Base { get; init; }

        /// <summary>
        /// The type of the implementing class.
        /// </summary>
        public Type Implementation { get; init; }

        public ClassInfo(Type implementationType, Type? baseType = null)
        {
            Implementation = implementationType;
            Base = baseType;
        }
    }
}
