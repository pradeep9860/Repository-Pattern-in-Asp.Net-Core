using Application.Repository.EntityFramework;
using Application.Service.Providers;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Application.Host
{
    public static class Bootstraper
    { 
        public static void Run(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ApplicationDbContext>();
             
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>)); 
            services.AddTransient<IMasterCompanyService, MasterCompanyService>(); 
        }
         
    }
}
