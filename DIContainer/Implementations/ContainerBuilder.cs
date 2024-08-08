using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIContainer.Interfaces;

namespace DIContainer.Implementations
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
