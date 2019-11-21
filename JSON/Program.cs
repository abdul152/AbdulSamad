using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace nugetpackages
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                   .AddEnvironmentVariables();
            if (args != null)
            {
                builder.AddCommandLine(args);
            }

            IConfigurationRoot configuration = builder.Build();
            //            // Following are comming from command line.            
            var color = configuration["book:color"];
            var fontSize = configuration["book:fontSize"];
            var pages = configuration["book:pages"];
            Console.WriteLine("Book Color:" + color + "\nBook fontsize:" + fontSize + "\nNo of Pages:" + pages);
            var platform = configuration["app:platform"];
            var genre = configuration["app:genre"];
            var version = configuration["app:version"];
            Console.WriteLine("\n\n\n\nApp Platform:" + platform + "\nApp Genre:" + genre + "\nCurrent Version:" + version);
            Console.ReadLine();
        }

    }
}
