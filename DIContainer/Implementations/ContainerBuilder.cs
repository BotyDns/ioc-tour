using DiContainer.Interfaces;

namespace DiContainer.Implementations
{
    class ContainerBuilder : IContainerBuilder
    {
        public IClassCollection ClassCollection { get; set; }

        public ContainerBuilder()
        {
            ClassCollection = new ClassCollection();
        }

        public DIContainer Build()
            => new DIContainer()
            {
                ClassCollection = ClassCollection
            };
    }
}
