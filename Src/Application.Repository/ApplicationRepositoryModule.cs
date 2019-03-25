using Core.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Repository
{
    public class ApplicationRepositoryModule : ApplicationModule
    {
        public override void PreInitialize(IServiceCollection serviceCollection, IConfiguration configuration)
        { 

        }

        public override void Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionString:Default"];
        }

        public override void PostInitialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            
        } 
      
    }
}
