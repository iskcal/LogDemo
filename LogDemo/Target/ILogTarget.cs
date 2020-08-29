using LogDemo.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo.Target
{
    public interface ILogTarget
    {
        void WriteLog(LogData logData);
    }
}
