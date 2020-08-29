using LogDemo.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo.Target
{
    public class ConsoleTarget : ILogTarget
    {
        public void WriteLog(LogData logData)
        {
            Console.WriteLine(logData);
        }
    }
}
