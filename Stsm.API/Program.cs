using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stsm.API
{
    class Program
    {
        static void Main(string[] args)
        {

            DbContext db = new DbContext();
            var lst= db.Appjmessage.ToList();
            //配置类
            var config = new ConfigurationBuilder()
                 .AddCommandLine(args)

                 .AddEnvironmentVariables(prefix: "ASPNETCORE_")//运行的环境变量
                 .Build();

            //web宿主
            var host = new WebHostBuilder()
                .UseConfiguration(config) //引入配置
                .UseKestrel() //使用Kestrel部署
                .UseUrls("http://localhost:8089") //修改Kestrel绑定的地址
                .UseContentRoot(Directory.GetCurrentDirectory())//引用根目录
                                                                //.UseIISIntegration() //引入IIS组件包
                .UseStartup<Startup>()//启动配置文件
                .Build();

            //运行web宿主
            host.Run();
        }
    }
}
