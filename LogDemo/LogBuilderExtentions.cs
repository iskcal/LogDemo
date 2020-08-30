using LogDemo.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo
{
    public static class LogBuilderExtentions
    {
        public static LogBuilder AddConsole(this LogBuilder builder)
        {
            builder.Targets.Add(new ConsoleTarget());
            return builder;
        }

        public static LogBuilder AddFile(this LogBuilder builder, string path)
        {
            builder.Targets.Add(new FileTarget(path));
            return builder;
        }
    }
}
