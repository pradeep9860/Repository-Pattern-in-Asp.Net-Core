using Application.Repository.EntityFramework;
using Core.DI;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Repository
{
    public class ApplicationRepositoryRegistrar : IServiceRegistrar
    {
        public void Register(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(); //this must be scoped
            serviceCollection.AddScoped<ApplicationDbContext>();//this must be scoped

            serviceCollection.AddTransient(typeof(IRepository<>), typeof(Repository<>));

        }

        public void Update(IServiceCollection serviceCollection)
        {
             
        }
    }
}
