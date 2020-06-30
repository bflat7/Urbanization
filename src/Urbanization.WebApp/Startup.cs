using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Urbanization.Data.Abstractions;
using Urbanization.Data.Stores;
using Urbanization.WebApp.Abstractions;
using Urbanization.WebApp.Services;

namespace Urbanization.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); // potential optimization here

            services.AddScoped<IUrbanizationByStateService, UrbanizationByStateService>();
            services.AddScoped<IUrbanizationByStateStore, UrbanizationByStateStore>();
            //services.AddScoped(IUrbanizationDbContext, )

            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles()

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapFallbackToController(controller: "Home", action: "Index");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "";
            });
        }
    }

    //public static IServiceCollection AddTest(this IServiceCollection services, Action<Urbanization>)
}
