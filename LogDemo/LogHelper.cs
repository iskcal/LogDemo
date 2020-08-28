using System;

namespace LogDemo
{
    public class LogHelper
    {
        public static void LogToConsole(string message, LogLevel level = LogLevel.Information)
        {
            var logData = new LogData(level, message);
            Console.WriteLine(logData);
        }
    }
}
