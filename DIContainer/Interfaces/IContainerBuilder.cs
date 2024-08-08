using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer.Interfaces
{
    public interface IContainerBuilder
    {
        IClassCollection ClassCollection { get; }


        DIContainer Build();
    }
}
