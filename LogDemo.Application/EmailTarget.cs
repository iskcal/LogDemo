using LogDemo.Event;
using LogDemo.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogDemo.Application
{
    public class EmailTarget : ILogTarget
    {
        private string _from;
        private string _to;

        public EmailTarget(string from, string to)
        {
            _from = from;
            _to = to;
        }

        public void WriteLog(LogData logData)
        {
            // 将日志对象写入邮件中            
        }
    }
}
