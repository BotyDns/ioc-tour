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
        public IClassCollection ClassCollection => throw new NotImplementedException();

        public DIContainer Build()
        {
            throw new NotImplementedException();
        }
    }
}
