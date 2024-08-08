using DIContainer.Interfaces;
using DIContainer.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer.Implementations
{
    class ClassCollection : IClassCollection
    {
        private ICollection<ClassInfo> Classes { get; set; }

        public ClassCollection()
        {
            Classes = [];
        }

        public IClassCollection AddClass<TClass>()
        {
            Classes.Add(new ClassInfo(typeof(TClass)));
            return this;
        }

        public IClassCollection AddClass<TInterface, TClass>()
        {
            Classes.Add(new ClassInfo(typeof(TClass), typeof(TInterface)));
            return this;
        }

        public ClassInfo? GetClassInfo<IBase>()
            => Classes.FirstOrDefault(ci => ci.Base == typeof(IBase) || ci.Implementation == typeof(IBase));
    }
}
