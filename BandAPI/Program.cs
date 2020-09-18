using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BandAPI.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BandAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();


            using (var scope = host.Services.CreateScope())
            {
                try {

                    var context = scope.ServiceProvider.GetService<BandAlbumContext>();
                    context.Database.EnsureDeleted();
                    context.Database.Migrate();

                 }
                catch(Exception e) {
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "An error occurred while migration in progress");

              }
            }


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
