using Application.Repository.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.OData.Extensions;
using Newtonsoft.Json.Serialization;
using Core.Formatter;
using Core;

namespace Application.Host
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            string connectionString = Configuration["ConnectionString:Default"];
            services.AddDbContext<ApplicationDbContext>
                        (options => options.UseSqlServer(connectionString));


            services.AddMvc()
                 .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver())
                 .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                 .AddMvcOptions(options =>
                 {
                     options.OutputFormatters.Add(new PascalCaseJsonProfileFormatter());
                 });  

            services.AddOData();

            //services.RegisterService();

            services.AddSingleton(Configuration);
            var serviceProvider = services.BuildServiceProvider();
            //IDatabaseFactory dbFactory = DatabaseFactories.SetFactory(Dialect.SQLServer, serviceProvider);

            services.RegisterApplicationCoreModule(serviceProvider);

            //Bootstraper.Run(services); // register dependency container
            //var serviceProvider = new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCors("corsGlobalPolicy");

            //app.UseHealthChecks("/healthcheck");


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.EnableDependencyInjection();
                routes.Filter().Select().Count().Expand().OrderBy();
            });
        }
    }
}
