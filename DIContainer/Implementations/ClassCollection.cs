using DiContainer.Interfaces;
using DiContainer.Util;

namespace DiContainer.Implementations
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

        public IClassCollection AddClass<TBase, TClass>()
            where TClass : TBase
        {
            Classes.Add(new ClassInfo(typeof(TClass), typeof(TBase)));
            return this;
        }

        public ClassInfo? GetClassInfo<IBase>()
            => GetClassInfo(typeof(IBase));

        public ClassInfo? GetClassInfo(Type classType)
            => Classes.FirstOrDefault(ci => ci.Base == classType || ci.Implementation == classType);
    }
}
