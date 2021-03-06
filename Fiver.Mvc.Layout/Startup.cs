﻿using Fiver.Mvc.Layout.Models.Home;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Fiver.Mvc.Layout
{
    public class Startup
    {
        public void ConfigureServices(
            IServiceCollection services)
        {
            services.AddScoped<IGreetingService, GreetingService>();
            services.AddMvc();
        }

        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
