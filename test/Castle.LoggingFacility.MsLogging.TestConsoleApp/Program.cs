using System;
using Microsoft.Extensions.Logging;

namespace Castle.LoggingFacility.MsLogging.TestConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loggerFactory = new LoggerFactory();

            loggerFactory.AddCastleLogger(new Castle.Core.Logging.ConsoleFactory());

            var logger = loggerFactory.CreateLogger<Program>();

            logger.LogInformation("This is an information log...");

            Console.WriteLine("----------------------------");
            Console.WriteLine("Press ENTER to exit...");
            Console.ReadLine();
        }
    }
}
