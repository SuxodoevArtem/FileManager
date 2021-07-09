using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using file_manager_back.Data;

namespace file_manager_back
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConnectionProvider.Connect("Host=localhost;Port=5432;Username=postgres;Password=Pa$$w0rd;Database=FileManager");
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
