using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //using (var ambiente = hostserver.Services.CreateScope())
            //{
            //    var services = ambiente.ServiceProvider;

            //    try
            //    {
            //        var context = services.GetRequiredService<BcoDbContext>();
            //        context.Database.Migrate();
            //    }
            //    catch (Exception e)
            //    {
            //        var logging = services.GetRequiredService<ILogger<Program>>();
            //        logging.LogError(e, "Nop se pudo realizar la migración");
            //    }
            //}
            //hostserver.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
