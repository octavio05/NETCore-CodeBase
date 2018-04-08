using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore_ProjectBase.Class;
using NetCore_ProjectBase.Interfaces;
using CoreConnection;

namespace NetCore_ProjectBase
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services
            services.AddMvc();

            // Configure AppSettings
            services.Configure<AppSettings>(settings =>
            {
                settings.Data = new Data()
                {
                    ConnectionString = Configuration["Data:ConnectionString"].ToString()
                };
            });

            // Configure CorePostgreSql
            services.AddSingleton<ICorePostgreSql>(connection => new CorePostgreSql(Configuration["Data:ConnectionString"].ToString()));

            // Configure BusinessLogic
            services.AddSingleton<IBusinessLogic, BusinessLogic>();

            // Configure DataAccess
            services.AddSingleton<IDataAccess, DataAccess>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "example",
                    template: "{controller=Home}/{action=Index}");
            });
        }
    }
}
