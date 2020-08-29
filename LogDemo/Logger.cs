using LogDemo.Event;
using LogDemo.Target;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LogDemo
{
    public class Logger
    {
        public List<ILogTarget> Targets { get; set; } = new List<ILogTarget>();

        public void LogToTarget(LogLevel level, string message)
        {
            var logData = new LogData(level, message);

            foreach (var target in Targets)
            {
                target.WriteLog(logData);
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
