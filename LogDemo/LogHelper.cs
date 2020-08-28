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

        public static void LogToConsoleAndFiles(string message, bool logToConsole, string[] logFilePaths, LogLevel level = LogLevel.Information)
        {
            if (logToConsole) LogToConsole(message, level);
            if(logFilePaths!=null)
            {
                foreach (var path in logFilePaths)
                {
                    LogToFile(message, path, level);
                }
            }
        }
    }
}
