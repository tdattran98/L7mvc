using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //tinfo200:[2021-03-11-dattr98-dykstra2] - 
            var host = CreateHostBuilder(args).Build();
            //tinfo200:[2021-03-11-dattr98-dykstra2] - 
            CreateDbIfNotExists(host);
            //tinfo200:[2021-03-11-dattr98-dykstra2] - 
            host.Run();
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                //tinfo200:[2021-03-11-dattr98-dykstra2] - try to call the initialize database class from DbInitializer
                //tinfo200:[2021-03-11-dattr98-dykstra2] - adding it the table from SchoolContext class.
                var services = scope.ServiceProvider;
                try
                {
                    //tinfo200:[2021-03-11-dattr98-dykstra2] - create the instance that is the dependency to SchoolContext class
                    var context = services.GetRequiredService<SchoolContext>();
                    //tinfo200:[2021-03-11-dattr98-dykstra2] - in case a variable is changed in data model, this helps give instruction to database to update the data.
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
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
