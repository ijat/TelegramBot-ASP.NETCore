using System;
using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;

namespace TelegramBotASPnetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "@TelegramBotASPnetCore";
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Async(a => a.RollingFile("Data/Log/log-{Date}.txt", restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Error))
                .WriteTo.Console(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information)
                .CreateLogger();

            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseUrls("http://0.0.0.0:20020")
                .UseStartup<Startup>()
                .UseSerilog()
                .Build();
    }
}
