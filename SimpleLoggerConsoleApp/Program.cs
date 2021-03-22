using System;
using SimpleLoggerLibrary;
using LoggingProxyLibrary;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLoggerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new Logger();

            consoleLogger.Info("Text info");
            consoleLogger.Warning("Text warning");
            consoleLogger.Error("Text error");

            var fileLogger = LoggingProxy<ILogger>.CreateInstance(new Logger(new FilePublisher()), consoleLogger);

            fileLogger.Info("Text info");
            fileLogger.Warning("Text warning");
            fileLogger.Error("Text error");

            var list = LoggingProxy<IList<int>>.CreateInstance(new List<int>(), consoleLogger);

            list.Add(2);
            list.Add(5);

            Console.ReadKey(true);
        }
    }
}
