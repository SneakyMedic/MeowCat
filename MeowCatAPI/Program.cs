using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;

namespace MeowCatAPI
{
    public class Program
    {
        public static string url = "http://localhost:80"; public static string confName = "config.txt"; public static string confDir = "stuffConfig";
        public static void Main(string[] args)
        {
            if (!(Directory.Exists(confDir)))
            {
                IO.DirectoryCreate(confDir);
            }
            if (!(File.Exists(confDir + "/" + confName)))
            {
                IO.Write(url, confName, confDir, false, true);
            }
            url = IO.ReadLine(confName, 0, confDir);
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseUrls(url);
                });
    }
}
