using Application.Service.Providers;
using Core.DI;
using Core.DI.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Service
{
    public class ApplicationServiceRegistrar : IServiceRegistrar
    {
        public void Update(IServiceCollection serviceCollection)
        {
            //throw new NotImplementedException();
        }

        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            //serviceCollection.AddTransient<IMasterCompanyService, MasterCompanyService>();

            serviceCollection.Scan(scan => scan
                 .FromAssemblyOf<MasterCompanyService>()
                     .AddClasses(classes => classes.AssignableTo<ITransientService>())
                         .AsImplementedInterfaces()
                         .WithTransientLifetime()

                     .AddClasses(classes => classes.AssignableTo<IScopedService>())
                         .As<IScopedService>()
                         .WithScopedLifetime());
        }
    }
}
