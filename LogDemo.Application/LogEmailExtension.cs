using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo.Application
{
    public static class LogEmailExtension
    {
        public static LogBuilder AddEmail(this LogBuilder builder, string from, string to)
        {
            builder.Targets.Add(new EmailTarget(from, to));
            return builder;
        }
    }
}
