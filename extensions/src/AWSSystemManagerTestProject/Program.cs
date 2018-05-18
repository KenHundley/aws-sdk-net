using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AWSSystemManagerTestProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = new LoggerFactory()
                .AddConsole()
                .AddDebug()
                .CreateLogger(typeof(Program));

            var host = WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(builder =>
                {
                    var config = builder.Build();
                    builder.AddAWSSystemManager(source =>
                    {
                        source.Path = config["SSM:Path"];
                        source.ReloadAfter = TimeSpan.FromSeconds(60);
                        source.OnLoadException = context =>
                        {
                            logger.LogCritical(context.Exception, "Failed to load configuration from SSM Parameter Store");
                            context.Ignore = false;
                        };
                    });
                })
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
