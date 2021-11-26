using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using MyFirstAppp.Interfaces;
using MyFirstAppp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppp.Models
{
    public sealed class Bootstrap
    {
        public static void Initialize()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<DependencyInjectionPageViewModel>().AsSelf();
            builder.RegisterType<CustomService>().As<ICustomService>();

            IContainer container = builder.Build();

            AutofacServiceLocator asl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => asl);
        }
    }
}
