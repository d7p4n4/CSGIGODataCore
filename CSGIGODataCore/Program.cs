using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CSGIGODataCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        /*
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureLogging((ctx, logging) =>
                {
                    logging.AddConfiguration(ctx.Configuration.GetSection("Logging"));
                });
        /*/
        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseUrls("http://89.46.75.137:8004")
            .UseKestrel()
            .UseStartup<Startup>();
    }
}
