using LogDemo.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo
{
    public class LogBuilder
    {
        public List<ILogTarget> Targets { get; }

        public LogBuilder()
        {
            Targets = new List<ILogTarget>();
        }

        public Logger CreateLogger()
        {
            return new Logger(Targets.ToArray());
        }
    }
}
