using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using NLog.Web;
using Serilog;
using Serilog.Events;
using System;

namespace CoreAdminLTE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Debug()
            //    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            //    // Filter out ASP.NET Core infrastructre logs that are Information and below
            //    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
            //    .Enrich.FromLogContext()
            //    .WriteTo.Console()
            //    .WriteTo.File("logs\\log-.txt", rollingInterval: RollingInterval.Day)
            //    .CreateLogger();
            
            //try
            //{
            //    Log.Information("啟動主機");
            //    CreateHostBuilder(args).Build().Run();
            //}
            //catch (Exception ex)
            //{
            //    Log.Fatal(ex, "主機意外終止");
            //}
            //finally
            //{
            //    Log.CloseAndFlush();
            //}

            //NLog
            var logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
            try
            {
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Get Error.");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                              
                }).UseNLog();
    }
}
