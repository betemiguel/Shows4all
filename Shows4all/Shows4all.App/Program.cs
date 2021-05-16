using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System;

namespace Shows4all.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
           CreateHostBuilder(args).Build().Run();
           var passwordHasher = new PasswordHasher<string>();
           Console.WriteLine(passwordHasher.HashPassword(null, "strong password"));
           Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
         Host.CreateDefaultBuilder(args)
              .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
