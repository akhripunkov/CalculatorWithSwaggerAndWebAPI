using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICalc4.Utilities;

namespace WebAPICalc4
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Calculator>().As<ICalculator>();
            return builder.Build();
        }
    }
}
