using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Stsm.API
{
    public class Startup
    {
        //加入服务项到容器种， 这个方法将会被runtime调用
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        /// <summary>
        /// 配置HTTP请求管道
        /// </summary>
        /// <param name="app">被用于构建应用程序的请求管道。只可以在 Startup 中的 Configure 方法里使用</param>
        /// <param name="env">提供了访问应用程序属性，如环境变量</param>
        /// <param name="loggerFactory">提供了创建日志的机制</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseDeveloperExceptionPage();  //抛出详细的异常错误界面
                                              //if (env.IsDevelopment()) //根据配置的环境为开发环境，则会配置抛出异常错误界面
                                              //{

            //}

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "GetAll" }
                );
            });

            //管道断路
            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}