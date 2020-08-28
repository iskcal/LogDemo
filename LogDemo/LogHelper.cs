using System;
using System.IO;

namespace LogDemo
{
    public class LogHelper
    {
        public static void LogToConsole(string message, LogLevel level = LogLevel.Information)
        {
            var logData = new LogData(level, message);
            Console.WriteLine(logData);
        }

        public static void LogToFile(string message, string logFilePath, LogLevel level = LogLevel.Information)
        {
            var logData = new LogData(level, message);

            using var fs = new FileStream(logFilePath, FileMode.Append);
            using var sw = new StreamWriter(fs);
            sw.WriteLine(logData);
        }
    }
}
