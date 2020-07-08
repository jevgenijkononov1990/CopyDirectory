using Ninject;
using Ninject.Modules;
using System.Collections.Generic;

namespace CopyDirectory.IoC
{
    public class CompositionRoot
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return _ninjectKernel.GetAll<T>();
        }
    }
}
