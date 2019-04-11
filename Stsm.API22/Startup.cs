using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Stsm.API22
{
    public class Startup:Microsoft.AspNetCore.Hosting.IStartup
    {
        public void Configure(IApplicationBuilder app)
        {

            app.UseDeveloperExceptionPage();  //抛出详细的异常错误界面
            //if (env.IsDevelopment()) //根据配置的环境为开发环境，则会配置抛出异常错误界面
            //{

            //}

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}",
                    defaults: new { controller = "Home", action = "GetAll" }
                );
            });

            //管道断路
            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();
            return services.BuildServiceProvider();

        }
    }
}