﻿using Core.DI.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Core.DI
{
    public class ServiceRegistrar : IServiceRegistrar
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        { 
            //serviceCollection.Scan(scan => scan
            //     .FromAssemblyOf<ServiceRegistrar>()
            //         .AddClasses(classes => classes.AssignableTo<ITransientService>())
            //             .AsImplementedInterfaces()
            //             .WithTransientLifetime()

            //         .AddClasses(classes => classes.AssignableTo<IScopedService>())
            //             .As<IScopedService>()
            //             .WithScopedLifetime());
        }

        public void Update(IServiceCollection serviceCollection)
        {
           // throw new NotImplementedException();
        }
    }
}
