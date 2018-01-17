
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PDBWebApp.Data;
using PDBWebApp.Services;
using PDBWebApp.Services.StudioServices;
using PDBWebApp.Services.WorkoutServices;


namespace PDBWebApp
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddDbContext<PDBWebAppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("PDBLocal")));
           
            services.AddScoped<IStudioData, SQLStudioData>();
            services.AddScoped<IWorkoutsData, SQLWorkoutData>();
            services.AddScoped<IScheduleData, SQLScheduleData>();
            services.AddScoped<IFillInfoData, SQLFillInfoData>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IConfiguration configuration, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                 
                await context.Response.WriteAsync($"notfound");
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute("Default", "{controller=Studio}/{action=Studio}/{id1?}");
            routeBuilder.MapRoute("Activities_Route", "{controller=Home}/{id1?}/{action=Index}/{id2?}"); 
        }
    }

  
}
