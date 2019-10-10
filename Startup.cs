using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CRUDelicious.Models;                              //added this line to register context class as service
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious
{
    public class Startup
    {
        // This public getter will be how you access the data from appsettings.json
        // To access the connection string itself, you would use the following:
        // Configuration["DBInfo:ConnectionString"]
        public IConfiguration Configuration {get;}
        // Here we will "inject" the default IConfiguration service, which will bind to appsettings.json by default
        // and then assign it to the Configuration property. This happens at the startup of our application.
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            Console.WriteLine(env.ContentRootPath);
            Console.WriteLine(env.IsDevelopment());
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Now we may use the connection string itself, bound to Configuration, to pass the required connection credentials to MySQL
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyContext>(options => options.UseMySql(Configuration["DBInfo:ConnectionString"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
