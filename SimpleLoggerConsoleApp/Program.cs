using System;
using SimpleLoggerLibrary;

namespace SimpleLoggerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new Logger();

            consoleLogger.Error("Text error");
            consoleLogger.Info("Text info");
            consoleLogger.Warning("Text warning");

            var fileLogger = new Logger(new FilePublisher());

            fileLogger.Error("Text error");
            fileLogger.Info("Text info");
            fileLogger.Warning("Text warning");

            Console.ReadKey(true);
        }
    }
}
