using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogDemo
{
    public class Logger
    {
        private bool _logToConsole;
        private string[] _logFilePaths;

        public Logger(bool logToConsole = false, string[] logFilePaths = null)
        {
            _logToConsole = logToConsole;
            _logFilePaths = logFilePaths;
        }

        public void LogToTarget(LogLevel level, string message)
        {
            var logData = new LogData(level, message);

            if (_logToConsole) LogToConsole(logData);
            if (_logFilePaths != null) LogToFiles(logData);
        }

        private void LogToConsole(LogData logData)
        {
            Console.WriteLine(logData);
        }

        private void LogToFiles(LogData logData)
        {
            foreach(string path in _logFilePaths)
            {
                using var fs = new FileStream(path, FileMode.Append);
                using var sw = new StreamWriter(fs);
                sw.WriteLine(logData);
            }
        }

        public void LogVerbose(string message)
            => LogToTarget(LogLevel.Verbose, message);

        public void LogDebug(string message)
            => LogToTarget(LogLevel.Debug, message);

        public void LogInformation(string message)
            => LogToTarget(LogLevel.Information, message);

        public void LogWarning(string message)
            => LogToTarget(LogLevel.Warning, message);

        public void LogError(string message)
            => LogToTarget(LogLevel.Error, message);

        public void LogFatal(string message)
            => LogToTarget(LogLevel.Fatal, message);
    }
}
