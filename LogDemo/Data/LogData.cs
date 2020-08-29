using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo.Event
{
    public class LogData
    {
        public DateTime Time { get; }
        public LogLevel Level { get; }
        public string Message { get; }

        public LogData(LogLevel level, string message)
        {
            Time = DateTime.UtcNow;
            Level = level;
            Message = message;
        }

        public override string ToString()
        {
            return $"[{Time.ToString()}][{Level.ToString()}]{Message}";
        }
    }
}
