using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking.IoC
{
    public static class Injector
    {
        public static IContainer Container;

        public static IContainer Configure(Func<IContainer> func)
        {
            Container = func();

            return func();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

    }
}
